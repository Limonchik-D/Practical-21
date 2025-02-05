using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_21
{
    internal class Time
    {
        public int hour;
        public int minutes;
        public int seconds;
        public Time()
        {
            hour = 0;
            minutes = 0;
        }
        public Time(int hour)
        {
            this.hour = hour;
            minutes = 0;
        }
        public Time (int hour, int minutes) : this(hour)
        {
            this.hour = hour;
            this.minutes = minutes;
        }
        public Time(int hour, int minutes, int seconds) : this(hour, minutes)
        {
            this.seconds = seconds;
        }

        public int SumTime()
        {
            return hour * 60 + minutes; // количество минут
        }
        public int SumSeconds()
        {
            return hour * 3600 + minutes * 60 + seconds; // количество секунд
        }
        public override string ToString()
        { 
            return $"Время: {hour} Ч {minutes} Мин {seconds} сек, всего минут: {SumTime()}, всего секунд: {SumSeconds()}";
        }
    }
}
