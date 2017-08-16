using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;

namespace VendingMachineSample.Abstractions.Classes
{
    class Slot<t>:Product,IVendingMachineProductSlot
    {
       public string slotCode;
       public bool hasProduct;

        decimal IVendingMachineProductSlot.ProductPrice
        {
            get { return this.Price; }
        }

        string IVendingMachineProductSlot.ProductName
        {
            get {return this.Name; }
        }

        string IVendingMachineProductSlot.SlotCode
        {
            get { return slotCode; }
        }

        bool IVendingMachineProductSlot.HasProduct
        {
            get { return hasProduct; }
        }

        public override string ToString()
        {
            return Name+" "+Price+" "+slotCode+" "+hasProduct;
        }
    }
}
