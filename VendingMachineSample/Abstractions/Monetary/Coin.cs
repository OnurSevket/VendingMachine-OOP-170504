using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstractions.Monetary
{
    public abstract class Coin : Money
    {
        public abstract int Diameter { get; }
    }
}
