using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overriding
{
    internal class TypeB : TypeA
    {
        #region Properties
        public int B { get; set; }
        #endregion

        #region Constructor
        public TypeB(int a , int b) : base(a)
        {
            B = b;
        }
        #endregion

        #region Methods

        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 from Dervied and I am Dervied");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from Dervied And TypeA : A = {A} , B = {B}"); ;
        }

        #endregion
    }
}
