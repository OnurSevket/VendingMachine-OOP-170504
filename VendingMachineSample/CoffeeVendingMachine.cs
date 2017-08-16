using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;
using VendingMachineSample.Abstractions.Classes;
using VendingMachineSample.Constants;
using VendingMachine.Abstractions.Monetary;

namespace VendingMachineSample
{
    class CoffeeVendingMachine : IVendingMachine<Coffee>
    {
        MachineState machineState;
        decimal AccumulatedAmount;
        private bool HasRefundMoney;
        List<Money> EnteredMoneyList;
        public static List<Slot<Coffee>> cofeeList;
        Slot<Coffee> selectedCofee;
        bool hasProduct = true;
        decimal tempTotalMoneyLoaded;
        int CubeAmount;
        int MilkAmount;
        int CofeeAmount;

        public void Ok()
        {
            if (selectedCofee != null)
            {
                foreach (Money Money in EnteredMoneyList)
                {
                    tempTotalMoneyLoaded += Money.Value;
                }
                Coffee cofee = new Coffee();
                cofee.Name = selectedCofee.Name;
                cofee.Price = selectedCofee.Price;
                CoffeeDispanser multipleDispanser = new CoffeeDispanser(cofee, hasProduct);
                MoneyBox<Money> moneybox = new MoneyBox<Money>();
                Money money = null;
                money.Value = selectedCofee.Price;
                moneybox.AddMoney(money);
                tempTotalMoneyLoaded = tempTotalMoneyLoaded - selectedCofee.Price;
                cofeeList.Remove(selectedCofee);
                if (cofeeList.Count == 0)
                {
                    machineState = MachineState.OutOfOrder;
                }
                tempTotalMoneyLoaded = 0;
                AccumulatedAmount = 0;
            }
        }

        public void Cancel()
        {
            if (selectedCofee.Price != 0)
            {
                selectedCofee.Name = "";
                selectedCofee.Price = 0;
                selectedCofee.slotCode = "";
                selectedCofee.hasProduct = false;
            }
            if (EnteredMoneyList.Count > 0)
            {
                EnteredMoneyList.Clear();
            }
            tempTotalMoneyLoaded = 0;
            AccumulatedAmount = 0;
        }

        public void SelectProduct(string SloteCode)
        {
            foreach (var item in cofeeList)
            {
                if (item.slotCode == SloteCode)
                {
                    if (item.hasProduct == true)
                    {
                        if (AccumulatedAmount < item.Price) //0
                        {
                            throw new Exception("Yetersiz para ");
                        }
                        else if (AccumulatedAmount > item.Price)
                        {
                            HasRefundMoney = true;
                            AccumulatedAmount = AccumulatedAmount - item.Price;
                            selectedCofee.slotCode = item.slotCode;
                        }
                        else if (AccumulatedAmount == item.Price)
                        {
                            HasRefundMoney = false;
                            selectedCofee.slotCode = item.slotCode;
                        }
                    }
                    else
                    {
                        throw new Exception("Bu ürün kalmamıştır");
                    }
                }
                else
                {
                    throw new Exception("Yanlis Slot kodu girdiniz");
                }
            }
            //
            //tek ürün seçilebicek
        }

        public void AdMoney(global::VendingMachine.Abstractions.Monetary.Money money)
        {
            AccumulatedAmount += money.Value;
            EnteredMoneyList.Add(money);
        }

        public MachineState MachineState
        {
            get
            {
                return this.machineState;
            }
        }

        decimal IVendingMachine<Coffee>.AccumulatedAmount
        {
            get
            {
                return this.AccumulatedAmount;
            }
        }

        bool IVendingMachine<Coffee>.HasRefundMoney
        {
            get
            {
                return this.HasRefundMoney;
            }
        }

        public void OK()
        {
            this.Ok();
        }

        public void AddMoney(Money money)
        {
            this.AddMoney(money);
        }

        public IEnumerable<Money> GetRefund()
        {
            return this.GetRefund();
        }
    }
}
