using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;
using VendingMachineSample.Abstractions.Classes;
using VendingMachineSample.Constants;
using VendingMachine.Abstractions.Monetary;
using System.IO;
using System.Xml.Serialization;

namespace VendingMachineSample
{
    class SnackVendingMachine : IVendingMachine<Snack>,IVendingMachineShowcase
    {
        public SnackVendingMachine(int slotCount)
        {
            EnteredMoneyList = new List<Money>();
            selectedProduct = new List<Slot<Snack>>();
            this.slotCount = slotCount;
        }

        static SnackVendingMachine()
        {
            snackList = new List<Slot<Snack>>();
            
        }

        public MachineState machineState;
        public decimal AccumulatedAmount;
        private bool HasRefundMoney;
        List<Money> EnteredMoneyList;
        public static List<Slot<Snack>> snackList;
        public  List<Slot<Snack>> selectedProduct;
        bool hasProduct = true;
        decimal tempTotalMoneyLoaded;

        public int slotCount;

        public void OK()
        {
            foreach (Money money in EnteredMoneyList)
            {
                tempTotalMoneyLoaded += money.Value;
            }
            foreach (var item in selectedProduct)
            {
                Snack snack = new Snack();
                snack.Name = item.Name;
                snack.Price = item.Price;

                MultipleDispanser multipleDispanser = new MultipleDispanser(snack, hasProduct, item.hasProduct);

                MoneyBox<Money> moneybox=new MoneyBox<Money>();

                Money money=null;
                money.Value = item.Price;
                moneybox.AddMoney(money);

                tempTotalMoneyLoaded=tempTotalMoneyLoaded - item.Price;
                
                snackList.Remove(item);
                if (snackList.Count==0)
                {
                   machineState= MachineState.OutOfOrder;

                }
            }
            tempTotalMoneyLoaded = 0;
            AccumulatedAmount = 0;
              
            selectedProduct.Clear();
           
        }

        IEnumerable<global::VendingMachine.Abstractions.Monetary.Money> GetRefund()
        {
            if (HasRefundMoney == true)
            {
                if (tempTotalMoneyLoaded > 0)
                {
                    Money money=null;
                    money.Value = tempTotalMoneyLoaded;
                    yield return money;
                }
                throw new Exception("Para üstü kalmadı:(");
            }
            throw new Exception("Para üstünüz yok");
        }

        public void SelectProduct(string slotCode)
        {
            foreach (var item in snackList)
            {
                if (item.slotCode == slotCode)
                {
                    if (item.hasProduct == true)
                    {
                        if (AccumulatedAmount <= 0)
                        {
                            throw new Exception("para bitti urun secimi yapamazsiniz");
                        }
                        selectedProduct.Add(item);
                        if (AccumulatedAmount > item.Price)
                        {
                            HasRefundMoney = true;
                            AccumulatedAmount= AccumulatedAmount - item.Price;
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
            EnteredMoneyList.Add(money);
        }

        public void Cancel()
        {
              if (selectedProduct.Count > 0)
                {
                    selectedProduct.Clear();
                }
                if (EnteredMoneyList.Count > 0)
                {
                    EnteredMoneyList.Clear();
                }
                tempTotalMoneyLoaded = 0;
                AccumulatedAmount = 0;
           
        }

        public IVendingMachineProductSlot this[string slotCode]
        {
            get {
                foreach (var item in snackList)
                {
                    if (item.slotCode == slotCode)
                        return item;
                }
                throw new Exception("Aranan slotta ürün bulunamadı.");
            }
        }

        public IVendingMachineProductSlot this[int slotNumber]
        {
            get { return snackList[slotNumber]; }
        }

        public int SlotCount
        {
            get { return slotCount ; }
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



        IVendingMachineProductSlot IVendingMachineShowcase.this[string slotCode]
        {
            get { throw new NotImplementedException(); }
        }

        IVendingMachineProductSlot IVendingMachineShowcase.this[int slotNumber]
        {
            get { throw new NotImplementedException(); }
        }

        int IVendingMachineShowcase.SlotCount
        {
            get { return slotCount; }
        }
    }
}




