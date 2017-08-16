using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;
using VendingMachineSample.Abstractions.Classes;
using VendingMachine.Abstractions.Monetary;
using VendingMachineSample.Constants;

namespace VendingMachineSample
{
    class CannedVendingMachine:IVendingMachine<Snack>
    {
        public CannedVendingMachine()
        {
            EnteredMoneyListCanned = new List<Money>();
           
            
        }

        static CannedVendingMachine()
        {
            CannedList = new List<Slot<Snack>>();
        }

        
        MachineState machineState;
        decimal AccumulatedAmount;
        private bool HasRefundMoney;
        List<Money> EnteredMoneyListCanned;
        public static List<Slot<Snack>> CannedList;
        public static Slot<Snack> selectedCannedProduct;
        bool hasProduct = true;
        decimal tempTotalMoneyLoaded;


        public void OK()
        {
            foreach (Money money in EnteredMoneyListCanned)
            {
                tempTotalMoneyLoaded += money.Value;
            }
        
                CannedDrink cannedDrink = new CannedDrink();
                cannedDrink.Name = selectedCannedProduct.Name;
                cannedDrink.Price = selectedCannedProduct.Price;

                SingleDispanser singleDispanser = new SingleDispanser(cannedDrink, hasProduct);

                MoneyBox<Money> moneybox = new MoneyBox<Money>();

                Money moneyToAdd = null;
                moneyToAdd.Value = selectedCannedProduct.Price;
                moneybox.AddMoney(moneyToAdd);

           

                CannedList.Remove(selectedCannedProduct);
                if (CannedList.Count == 0)
                {
                    machineState = MachineState.OutOfOrder;
                }
          
            tempTotalMoneyLoaded = 0;
            AccumulatedAmount = 0;

     

        }

        IEnumerable<global::VendingMachine.Abstractions.Monetary.Money> GetRefund()
        {
            if (HasRefundMoney == true)
            {
                if (tempTotalMoneyLoaded > 0)
                {
                    Money money = null;
                    money.Value = tempTotalMoneyLoaded;
                    yield return money;
                }
                throw new Exception("Para üstü kalmadı:(");
            }
            throw new Exception("Para üstünüz yok");
        }

        public void SelectProduct(string slotCode)
        {
            foreach (var item in CannedList)
            {
                if (item.slotCode == slotCode)
                {
                    if (item.hasProduct == true)
                    {
                        if (AccumulatedAmount <= 0)
                        {
                            throw new Exception("para bitti urun secimi yapamazsiniz");
                        }
                       
                        //selectedProductCanned.Add(item);
                        selectedCannedProduct = item;
                        if (AccumulatedAmount > item.Price)
                        {
                            HasRefundMoney = true;
                           // AccumulatedAmount = AccumulatedAmount - item.Price;
                        }
                        break;
                    }
                    else
                    {
                        hasProduct = false;
                    }
                }
                else
                {
                    throw new Exception("Yanlis Slot kodu girdiniz");
                }
            }
        }

        public void AddMoney(global::VendingMachine.Abstractions.Monetary.Money money)
        {
            AccumulatedAmount += money.Value;
            EnteredMoneyListCanned.Add(money);
        }

        public void Cancel()
        {
         
            if (EnteredMoneyListCanned.Count > 0)
            {
                EnteredMoneyListCanned.Clear();
            }
            selectedCannedProduct = null;
            tempTotalMoneyLoaded = 0;
            AccumulatedAmount = 0;
        }



        Constants.MachineState IVendingMachine<Snack>.MachineState
        {
            get { return this.machineState; }
        }

        void IVendingMachine<Snack>.SelectProduct(string slotCode)
        {
            this.SelectProduct(slotCode);
        }

        void IVendingMachine<Snack>.OK()
        {
            this.OK();
        }

        void IVendingMachine<Snack>.Cancel()
        {
            this.Cancel();
        }

        void IVendingMachine<Snack>.AddMoney(global::VendingMachine.Abstractions.Monetary.Money money)
        {
            this.AddMoney(money);
        }

        IEnumerable<global::VendingMachine.Abstractions.Monetary.Money> IVendingMachine<Snack>.GetRefund()
        {
            return this.GetRefund();
        }

        decimal IVendingMachine<Snack>.AccumulatedAmount
        {
            get { return AccumulatedAmount; }
        }

        bool IVendingMachine<Snack>.HasRefundMoney
        {
            get { return HasRefundMoney; }
        }
    }
}
