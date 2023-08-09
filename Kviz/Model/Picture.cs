using System;

namespace Kviz.Model
{
    internal class Picture
    {
        public string Path { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Answer { get; set; }

        public Picture(string path, string option1, string option2, string option3, string answer)
        {
            this.Path = path;
            this.Option1 = option1;
            this.Option2 = option2;
            this.Option3 = option3;
            this.Answer = answer;
        }


    }
}
