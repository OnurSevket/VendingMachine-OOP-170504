using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;

namespace VendingMachineSample.Abstractions.Classes
{
    class MultipleDispanser:IVendingMachineDispenserMultiple<Snack> 
    {
        public MultipleDispanser(Snack snack, bool DispenserSlotIsFull, bool DispenserSlotHasProducts)
        {
            this.snack=snack;
            this.DispenserSlotIsFull = DispenserSlotIsFull;
            this.DispenserSlotHasProducts = DispenserSlotHasProducts;
        }

        Snack snack;
        bool DispenserSlotIsFull;
        bool DispenserSlotHasProducts;
        Snack GetProduct<TDesiredProduct>() where TDesiredProduct : Snack
         {
            return snack;
         }


        bool IVendingMachineDispenserMultiple<Snack>.DispenserSlotIsFull
        {
            get { return this.DispenserSlotIsFull; }
        }

        bool IVendingMachineDispenserMultiple<Snack>.DispenserSlotHasProducts
        {
            get { return this.DispenserSlotHasProducts; }
        }

        Snack IVendingMachineDispenserMultiple<Snack>.GetProduct<Snack>()
        {
            Snack snack1 = (Snack)this.snack;
            return snack1;
        }
    }
}
