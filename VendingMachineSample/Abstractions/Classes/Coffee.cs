using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSample.Abstractions.Classes
{
    class Coffee:Product,ICoffee
    {
        public bool Mix;
        public int CoffeeRate;
        public int WaterRate;
        public int sugar;
        public int MilkRate;
       
        
        string ICoffee.Name
        {
            get { return this.Name; }
        }

        decimal ICoffee.Price
        {
            get { return this.Price; }
        }

        void ICoffee.Mix()
        {
            this.Mix=true;
        }

        int AddMilk(int amount)
        {
            return MilkRate+amount;
        }
        //yeni bir metot olustur ve asagida this ile onu cagir
        void ICoffee.ExtraMilk(MilkQuantity milkQuantity)
        {
           //switch(milkQuantity){

              // case 0: MilkQuantity.little: this.AddMilk(30);
           
           
         //  }
            this.MilkRate = 30;
        }

        void ICoffee.ExtraSugar(int cube)
        {
            this.sugar += cube;
        }
    }
}
