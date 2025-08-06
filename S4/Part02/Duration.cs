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

        public int ToSeconds()
        {
            return (Hours * 3600) + (Minutes * 60)  + Seconds;
        }

        #endregion

        #region Operator overLoading

        public static Duration operator +(Duration Left , Duration Right)
        {
            return new Duration((Left?.ToSeconds() ?? 0 ) + (Right?.ToSeconds() ?? 0));

        }
        public static Duration operator +(Duration Left , int Right)
        {

            return new Duration((Left?.ToSeconds() ?? 0) + Right);
 
        }
        public static Duration operator +(int Left , Duration Right)
        {

            return new Duration(Left + (Right?.ToSeconds() ?? 0));
     
        }
        public static Duration operator ++(Duration D)
        {
            return new Duration((D?.ToSeconds() ?? 0) + 60);

        }
        public static Duration operator --(Duration D)
        {
            return new Duration((D?.ToSeconds() ?? 0) - 60);

        }
        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration((Left?.ToSeconds() ?? 0) - (Right?.ToSeconds() ?? 0));

        }

        public static bool operator >(Duration Left, Duration Right)
        {
            return Left.ToSeconds() > Right.ToSeconds();
        }
        public static bool operator <(Duration Left, Duration Right)
        {
            return Left.ToSeconds() < Right.ToSeconds();
        }
        public static bool operator <=(Duration Left, Duration Right)
        {
            return Left.ToSeconds() <= Right.ToSeconds();
        }
        public static bool operator >=(Duration Left, Duration Right)
        {
            return Left.ToSeconds() >= Right.ToSeconds();
        }

        public static bool operator true(Duration D)
        {
            return D.ToSeconds() > 0;
        }
        public static bool operator false(Duration D)
        {
            return D.ToSeconds() <= 0;
        }


        #endregion

        #region Casting Operator

        public static explicit operator DateTime(Duration D)
        {
            return new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,D.Hours,D.Minutes,D.Seconds);
        }

        #endregion
    }
}
