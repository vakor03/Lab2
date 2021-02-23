using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Read and write to/from file +
            //TODO: Reading LineByLine +
            //TODO: Checking results
            //TODO: Resulting table .csv
            FileManager fl = new FileManager("../../../../Examples");
            List<string> strings = fl.ReadFiles();
            Teams[] teams = new Teams[strings.Count];
            for (int i = 0; i < strings.Count; i++)
            {
                teams[i] = new Teams(strings[i]);
            }
            fl.WriteToFile(Teams.CreateResultingTable(teams));
            
            
           
        }
    }
}