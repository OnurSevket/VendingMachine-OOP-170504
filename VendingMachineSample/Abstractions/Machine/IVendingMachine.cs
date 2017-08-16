using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Stuff;
using VendingMachine.Abstractions.Monetary;
using VendingMachineSample.Constants;


namespace VendingMachine.Abstractions.Machine
{
    public interface IVendingMachine<TProduct> where TProduct : IProduct
    {
        MachineState MachineState { get; }

        void SelectProduct(string productCode);
        void OK();
        void Cancel();
        void AddMoney(Money money);
        IEnumerable<Money> GetRefund();


        decimal AccumulatedAmount { get; }
        bool HasRefundMoney { get; }

    }
}
