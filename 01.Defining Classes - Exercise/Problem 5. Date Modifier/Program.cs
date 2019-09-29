using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Date_Modifier
{
    public class Program
    {
        public static void Main()
        {
            var firstData = Console.ReadLine();
            var secondData = Console.ReadLine();
            var firstDatetime = DateTime.ParseExact(firstData, "y/mm/dd", CultureInfo.CurrentCulture);
            Console.WriteLine(firstDatetime.Day);
        }
    }
}
