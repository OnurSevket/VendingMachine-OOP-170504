using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSample.Abstractions.Classes
{
    class CannedDrink:Product,ICannedDrinks
    {


        string ICannedDrinks.Name
        {
            get { return this.Name; }
        }

        decimal ICannedDrinks.Price
        {
            get { return this.Price; }
        }
    }
}
