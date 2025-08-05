using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overriding
{
    internal class DerviedClass2 : BaseClass
    {
        #region Methods

        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerviedClass2");
        }

        #endregion
    }
}
