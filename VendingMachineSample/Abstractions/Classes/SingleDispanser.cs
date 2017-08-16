using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;

namespace VendingMachineSample.Abstractions.Classes
{
    class SingleDispanser:IVendingMachineDispenserSingle<CannedDrink>
    {
        public SingleDispanser(CannedDrink CannedDrink, bool IsDispenserFull)
        {
            this.CannedDrink = CannedDrink;
            this.IsDispenserFull = IsDispenserFull;
        }
        bool IsDispenserFull;

        CannedDrink CannedDrink;
        CannedDrink GetProduct()
        {
            return CannedDrink;
        }


        bool IVendingMachineDispenserSingle<CannedDrink>.DispenserSlotIsFull
        {
            get { return this.IsDispenserFull; }
        }

        CannedDrink IVendingMachineDispenserSingle<CannedDrink>.GetProduct()
        {
            return CannedDrink;
        }
    }
}
