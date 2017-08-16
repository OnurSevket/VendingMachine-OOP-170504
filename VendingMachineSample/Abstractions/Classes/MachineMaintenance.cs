using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Abstractions.Machine;
using VendingMachineSample.Constants;
namespace VendingMachineSample.Abstractions.Classes
{
    class MachineMaintenance:IVendingMachineMaintenance
    {


        void IVendingMachineMaintenance.SwitchOn()
        {
            throw new NotImplementedException();
        }

        void IVendingMachineMaintenance.SwitchOff()
        {
            throw new NotImplementedException();
        }

        Constants.MachineState IVendingMachineMaintenance.MachineState
        {
            get { throw new NotImplementedException(); }
        }

        bool IVendingMachineMaintenance.OpenDoor(string keycode)
        {
            throw new NotImplementedException();
        }

        bool IVendingMachineMaintenance.LockDoor()
        {
            throw new NotImplementedException();
        }

        Constants.DoorState IVendingMachineMaintenance.DoorState
        {
            get { throw new NotImplementedException(); }
        }

        void IVendingMachineMaintenance.AddStuff<TStuff>(TStuff stuff)
        {
            throw new NotImplementedException();
        }

        TStuff IVendingMachineMaintenance.RemoveStuff<TStuff>(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
