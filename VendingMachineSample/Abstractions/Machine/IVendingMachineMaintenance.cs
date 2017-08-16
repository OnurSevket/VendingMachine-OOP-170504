using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Stuff;
using VendingMachineSample.Constants;

namespace VendingMachine.Abstractions.Machine
{
    public interface IVendingMachineMaintenance
    {
        void SwitchOn();
        void SwitchOff();
        MachineState MachineState { get; }

        bool OpenDoor(string keycode);
        bool LockDoor();
        DoorState DoorState { get; }

        void AddStuff<TStuff>(TStuff stuff) where TStuff : IStuff;
        TStuff RemoveStuff<TStuff>(int amount) where TStuff : IStuff;
    }
}
