using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Kviz.Model;
using Path = System.IO.Path;

namespace CityscapeGuess.Model
{
    internal class PictureService
    {
        public static List<Picture> LoadPictures()
        {
            List<Picture> pictures = new();
            List<Picture> pictureList = new();
            try
            {
                var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                var file = Path.Combine(projectFolder, @"resources\data.txt");
                StreamReader streamReader = new StreamReader(file);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    String[] parts = line.Split('#');
                    pictures.Add(new Picture(parts[0], parts[1], parts[2], parts[3], parts[4]));
                }
                Random rnd = new Random();
                while (pictureList.Count < 10)
                {
                    int index = rnd.Next(pictures.Count);
                    if (!pictureList.Contains(pictures[index]))
                    {
                        pictureList.Add(pictures[index]);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return pictureList;
        }
    }
}
