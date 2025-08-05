using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overloading
{
    internal class Rectangle
    {
        #region Properties

        public int Width { get; set; }

        public int Height { get; set; }

        #endregion

        #region Constructor

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width , int hieght)
        {
            Width = width;
            Height = hieght;
        }

        public Rectangle(int num) : this(num , num)
        {            
        }

        #endregion
        #region Methods

        public override string ToString()
        {
            return $"Width = {Width} , Height = {Height}";
        }

        #endregion
    }
}
