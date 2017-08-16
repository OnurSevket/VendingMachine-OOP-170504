using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSample.Abstractions.Classes
{
    class Snack:Product,ISnack
    {
       

        string ISnack.Name
        {
            get { return this.Name; }
        }

        decimal ISnack.Price
        {
            get { return this.Price; }
        }

        

    }
}
