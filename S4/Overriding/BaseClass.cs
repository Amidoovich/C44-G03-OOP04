using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overriding
{
    internal class BaseClass
    {
        #region Methods

        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }

        #endregion
    }
}
