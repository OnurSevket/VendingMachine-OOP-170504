using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine.Abstractions.Stuff
{
    public interface IProduct : IStuff
    {
        decimal Price { get; }
    }
}
