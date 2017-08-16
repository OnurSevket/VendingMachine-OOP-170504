using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstractions.Machine
{
    public interface ICabinet
    {
        int Width { get; }
        int Height { set; }
        int Depth { get; }
    }
}
