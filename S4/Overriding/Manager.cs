using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overriding
{
    internal class Manager : Employee
    {
        #region Methods

        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing"); ;
        }

        #endregion
    }
}
