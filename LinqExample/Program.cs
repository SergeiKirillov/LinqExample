using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectTeams = from t in teams
                              where t.ToUpper().StartsWith("Б")
                              orderby t
                              select t;
            foreach  (string s in selectTeams)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
