﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub.Skoczen.RPNCalculator.Operations
{
    interface IOperation
    {
        StackElement Operate(StackElement e1, StackElement e2);
    }
}
