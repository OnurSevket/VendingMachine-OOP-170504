﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Abstractions.Monetary
{
    public abstract class Money
    {
       
        public abstract decimal Value
        {

            get;
            set;
        }
    }
}
