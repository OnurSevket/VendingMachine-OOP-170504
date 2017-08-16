using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Monetary;

namespace VendingMachineSample.Abstractions.Classes
{
   public class MoneyBox<tMoney> where tMoney : Money
    {
        public MoneyBox() {
        
        }
        static MoneyBox()
        {
            moneyList = new List<tMoney>();
        }

        decimal TotalMoneyInMoneyBox;
        static List<tMoney> moneyList;

        public void AddMoney(tMoney money)
        {
            moneyList.Add(money);
            TotalMoneyInMoneyBox += money.Value;

        }


    }
}
