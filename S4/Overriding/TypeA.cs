using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overriding
{
    internal class TypeA
    {
        #region Properties
        public int A { get; set; }
        #endregion

        #region Constructor
        public TypeA (int a)
        {
            A = a;
        }
        #endregion

        #region Methods

        public void MyFun01()
        {
            Console.WriteLine("This is MyFun01 from Base and I am Base");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from Base and I am Base And TypeA : A = {A}");
        }


        #endregion
    }
}
