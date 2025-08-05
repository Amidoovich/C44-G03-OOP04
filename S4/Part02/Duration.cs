using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Part02
{
    internal class Duration
    {
        #region Properties 

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion

        #region Constructors

        public Duration()
        {
            
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            Seconds = seconds % 60;

        }

        #endregion

        #region Methods

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            if (Hours == 0)
                return $"Minutes:{Minutes}, Seconds:{Seconds}";

            return $"Hours:{Hours}, Minutes:{Minutes}, Seconds:{Seconds}";

        }

        #endregion
    }
}
