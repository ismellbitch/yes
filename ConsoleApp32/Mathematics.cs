using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Mathematics : Time
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public Mathematics(int hours, int minutes, int seconds) : base(hours, minutes, seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public override string GetDiscipline()
        {
            return "Попал в матешу";
        }
    }
}
