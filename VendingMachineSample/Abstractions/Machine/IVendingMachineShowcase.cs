using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstractions.Machine
{
    public interface IVendingMachineShowcase
    {
        IVendingMachineProductSlot this[string slotCode] { get; }
        IVendingMachineProductSlot this[int slotNumber] { get; }
        int SlotCount { get; }
    }
}
