using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;

namespace VendingMachineSample.Abstractions.Classes
{
    class ShowCase<TSlot>:IVendingMachineShowcase where TSlot:IVendingMachineProductSlot
    {
        public ShowCase(int slotCount )
        {
            slots =new TSlot[slotCount];
            this.slotCount = slotCount;
        }
        
        public static TSlot[]  slots;
        int  slotCount;
        IVendingMachineProductSlot IVendingMachineShowcase.this[string slotCode]
        {
            get 
            {
                foreach (TSlot item in slots)
                {
                    if (item.SlotCode == slotCode)
                        return item;
                }
                throw new Exception("Yanlış ürün kodu girdiniz");
            }
        }

        IVendingMachineProductSlot IVendingMachineShowcase.this[int slotNumber]
        {
            get 
            {
                try
                {
                    return slots[slotNumber];
                }
                catch (Exception ex)
                {

                    throw new Exception("Slot numarası bulunamadı");
                }
            }
        }

        int IVendingMachineShowcase.SlotCount
        {
            get { return this.slotCount; }
        }
    }
}
