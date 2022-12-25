using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Time
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public virtual string GetDiscipline()
        {
            return "Не попал)";
        }
    }
}
