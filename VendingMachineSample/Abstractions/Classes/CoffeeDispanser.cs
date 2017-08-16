using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;

namespace VendingMachineSample.Abstractions.Classes
{
    class CoffeeDispanser:IVendingMachineDispenserSingle<Coffee>
    {
        public CoffeeDispanser(Coffee coffee, bool IsDispenserFull)
        {
            this.coffee = coffee;
            this.IsDispenserFull = IsDispenserFull;
        }

        bool IsDispenserFull;
        Coffee coffee;
        Coffee GetProduct()
        {
            return coffee;
        }


        bool IVendingMachineDispenserSingle<Coffee>.DispenserSlotIsFull
        {
            get { return this.IsDispenserFull; }
        }

        Coffee IVendingMachineDispenserSingle<Coffee>.GetProduct()
        {
            return coffee;
        }


    }
}
