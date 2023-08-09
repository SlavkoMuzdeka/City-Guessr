using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CityscapeGuess.Model;
using Kviz.Model;
using Path = System.IO.Path;

namespace Kviz
{
    public partial class MainWindow : Window
    {
        private int currentValue;               // A variable used for progress bar
        private int correctAnswers = 0;         // The number of correct answers the user received at the end of the game
        private DispatcherTimer? timer;         // Variable used as a timer for progress bar
        private int numberOfQuestions = 0;      // Ordinal number of questions
        private readonly List<Picture> pictures;// List of objects that represent a "question"
        private Picture? currPicture;           // The current "picture" is a question
        private readonly Login Login;           // Reference to Login form
        private readonly string userName;

        public MainWindow(Login login, string userName)
        {
            InitializeComponent();
            pictures = PictureService.LoadPictures();
            LoadQuestion();
            this.Login = login;
            login.Close();
            this.userName = userName;
        }

        public MainWindow(Results res, string userName)
        {
            InitializeComponent();
            pictures = PictureService.LoadPictures();
            LoadQuestion();
            res.Close();
            this.userName = userName;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = currentValue;
            currentValue -= 10;
            if (currentValue < 0)
            {
                timer.Stop();
                if (numberOfQuestions == pictures.Count)
                {
                    btn1.IsEnabled = false;
                    btn2.IsEnabled = false;
                    btn3.IsEnabled = false;
                    timer.Stop();
                    progressBar.Foreground = new SolidColorBrush(Color.FromRgb(95, 158, 160));
                    SaveResult();
                    new Results(correctAnswers, this, userName).ShowDialog();
                }
                else
                {
                    LoadQuestion();
                }
            }
        }

        /*
         * Helper method by which we load a question from the question list and display it on the screen
         */
        private void LoadQuestion()
        {
            StartTimer();
            currPicture = pictures[numberOfQuestions];
            lblNumOfQuestion.Content = (numberOfQuestions + 1).ToString();
            SetQuestion();
            numberOfQuestions++;
        }

        /*
         * Helper method that starts the timer for each new question
         * The user has 10 seconds to answer the question.
         */
        private void StartTimer()
        {
            currentValue = 100;
            timer = new()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /*
         * Helper method with which we post the appropriate picture, as well as answers to the given question
         */
        private void SetQuestion()
        {
            btn1.Content = "     " + currPicture.Option1;
            btn2.Content = "     " + currPicture.Option2;
            btn3.Content = "     " + currPicture.Option3;

            try
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                bitmap.UriSource = new Uri(projectFolder + "" + currPicture.Path);
                bitmap.EndInit();
                img.Source = bitmap;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Try again." + ex.Message);
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string? btnText = btn.Content.ToString();
            try
            {
                timer.Stop();
                if (btnText.Equals("     " + currPicture.Answer))
                {
                    correctAnswers++;
                }
                if (numberOfQuestions == pictures.Count)
                {
                    btn1.IsEnabled = false;
                    btn2.IsEnabled = false;
                    btn3.IsEnabled = false;
                    timer.Stop();
                    progressBar.Foreground = new SolidColorBrush(Color.FromRgb(95, 158, 160));
                    SaveResult();
                    new Results(correctAnswers, this, userName).ShowDialog();
                }
                else
                {
                    LoadQuestion();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveResult()
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var file = Path.Combine(projectFolder, @"resources\results.txt");
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(userName + "#" + correctAnswers + "/10");
            writer.Close();
        }

    }
}
