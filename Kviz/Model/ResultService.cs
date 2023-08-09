using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kviz.Model
{
    internal class ResultService
    {

        public static List<Result> LoadResults()
        {
            List<Result> results = new();
            try
            {
                var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                var file = Path.Combine(projectFolder, @"resources\results.txt");
                StreamReader streamReader = new StreamReader(file);
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    String[] parts = line.Split('#');
                    results.Add(new Result(parts[0], parts[1]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return results;
        }

    }
}
