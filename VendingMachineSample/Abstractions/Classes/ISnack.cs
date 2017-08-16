using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSample.Abstractions.Classes
{
    interface ISnack
    {
        string Name { get; }
        decimal Price { get; }
       
          
    }
}
