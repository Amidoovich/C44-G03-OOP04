using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overriding
{
    internal class DerivedClass1 : BaseClass
    {
        #region Methods

        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerviedClass1"); 
        }

        #endregion
    }
}
