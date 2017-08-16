using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSample.Abstractions.Classes
{
    interface ICoffee
    {
        string Name { get; }
        decimal Price { get; }

        void Mix();

        void ExtraMilk(MilkQuantity milkQuantity);

        void ExtraSugar(int cube);
    }
}
