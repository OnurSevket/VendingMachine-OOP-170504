using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstractions.Machine
{
    public interface IVendingMachineProductSlot
    {
        decimal ProductPrice { get; }

        string ProductName { get; }

        string SlotCode { get; }

        bool HasProduct { get; }
    }
}

