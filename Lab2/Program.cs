using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Read and write to/from file
            //TODO: Reading LineByLine
            //TODO: Checking results
            //TODO: Resulting table .csv
            Teams team1 = new Teams("Chelsea FC,3:0,0:0,1:0,0:2,4:1,3:1,0:3,1:5,0:2,4:1");
            Teams team2 = new Teams("Chelsee FC,0:0,0:0,1:0,0:2,4:1,3:1,0:3,1:5,0:2,4:1");
            Console.WriteLine(String.Join("\n", Teams.CreateResultingTable( new []{team1,team2})));
            
            team1.ToString();
        }

        
        
    }
}