 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Stuff;

namespace VendingMachineSample
{
    
   abstract class Product:IProduct
    {

        public decimal Price;
        public string Name;


        decimal IProduct.Price
        {
            get { return this.Price; }
        }

        string IStuff.Name
        {
            get { return this.Name; }
        }
    }
}
