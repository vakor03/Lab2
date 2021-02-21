using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;

namespace Lab2
{
    public class FileManager
    {
        private string Path;

        public FileManager(string path)
        {
            Path = path;
        }

        public List<string> ReadFiles()
        {
            string[] filesList = Directory.GetFiles(Path);
            List<string> teamsRes = new List<string>();
            foreach (var filePath in filesList)
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    int count = int.Parse(sr.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        teamsRes.Add(sr.ReadLine());
                    }
                }
            }

            return teamsRes;
        }

        public void WriteToFile(string[] text)
        {
            using (FileStream fs = new FileStream(Path + "\\results.csv", FileMode.Create))
            {
            }
            using (StreamWriter sw = new StreamWriter(Path + "\\results.csv"))
            {
                foreach (var line in text)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}