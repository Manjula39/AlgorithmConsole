using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(1990, 7, 10, 7, 10, 24);
            Console.WriteLine("day is {0} ", dob.Day);
            Console.WriteLine(" day of year " + dob.DayOfYear);
            Console.WriteLine("day of week {0} ", dob.DayOfWeek);
            DateTime aDay = DateTime.Now;
                                         
            TimeSpan aMonth = new TimeSpan(30, 0, 0, 0);
            DateTime aDayAfterAmonth = aDay.Add(aMonth);
          

        }
    }
}
