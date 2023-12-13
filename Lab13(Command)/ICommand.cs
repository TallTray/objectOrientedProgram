﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Command_
{
    public interface ICommand
    {
        public void Execute();
        public ICommand GetReverseAction();
    }
}
