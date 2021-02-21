using System;

namespace Lab2
{
    public class Teams
    {
        private int Points;
        private string Name;

        public Teams(string str)
        {
            string[] scores = str.Split(',');
            int points = 0;
            Name = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                int point1 = Int32.Parse(scores[i].Split(':')[0]);
                int point2 = Int32.Parse(scores[i].Split(':')[1]);
                if (point1>point2)
                {
                    points += 3;
                }else if (point1 == point2)
                {
                    points += 1;
                }
            }
            Points = points;
        }

        public void ToString()
        {
            Console.WriteLine($"Team name: {Name}, points: {Points}");
        }
    }
}