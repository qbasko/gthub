﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub.Skoczen.RPNCalculator.Operations
{
    class Inv:IOperation
    {
        public StackElement Operate(StackElement e1, StackElement e2)
        {
            e2 = new StackElement("1");
            return e2 / e1;
        }
    }
}
