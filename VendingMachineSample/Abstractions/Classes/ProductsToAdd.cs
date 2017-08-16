using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSample.Abstractions.Classes
{
    public class ProductsToAdd
    {
       static ProductsToAdd()
        {
            ProductsToAddList = new List<ProductsToAdd>();
        }
        public string ProductName;
        public string ProductCode;
        public string SlotCode;
        public int Amount;
        public decimal Price;

        public static List<ProductsToAdd> ProductsToAddList;

        public void AddToProductList(ProductsToAdd pr)
        {
            ProductsToAddList.Add(pr);
        }
    }
}
