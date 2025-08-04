using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overloading
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }

        public int Img { get; set; }

        #endregion



        #region Methods

        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }

        #endregion

        #region Operator Overloading

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Img = (left?.Img ?? 0) - (right?.Img ?? 0)
            };
        }

        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Img = C?.Img ?? 0
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Img = C?.Img ?? 0
            };
        }

        public static bool operator >(Complex left , Complex right)
        {
            // left.real > right.real => true
            // left,real < right.real => false
            // left.real == right.real
            // left.img > right.img => true
            // left.img < right.img => false
            
            if(left.Real == right.Real)
                return left.Img > right.Img;
            else
                return left.Real > right.Real;


        }
        public static bool operator <(Complex left , Complex right)
        {

            
            if(left.Real == right.Real)
                return left.Img < right.Img;
            else
                return left.Real < right.Real;


        }
        #endregion
    }
}
