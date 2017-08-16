using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Stuff;

namespace VendingMachine.Abstractions.Machine
{
    public interface IVendingMachineDispenserMultiple<TProduct> where TProduct : IProduct
    {
        bool DispenserSlotIsFull { get; }
        bool DispenserSlotHasProducts { get; }
        TDesiredProduct GetProduct<TDesiredProduct>() where TDesiredProduct : TProduct;
    }
}
