using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstractions.Monetary
{
    public abstract class Banknote : Money
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
    }
}
