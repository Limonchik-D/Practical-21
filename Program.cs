using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.hour = 9;
            time.minutes = 30;
            time.seconds = 90;

            Time time1 = new Time(12, 30, 45); //Явная инициализация
            Console.WriteLine(time1);

            Console.Write("Введите кол-во часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во минут: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во секунд: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Time time2 = new Time(h, m, s);
            Console.WriteLine(time2);
        }
    }
}
