﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jakub.Skoczen.RPNCalculator.Operations
{
    class Sqrt : IOperation
    {
        public StackElement Operate(StackElement e1, StackElement e2)
        {
            double val = double.Parse(e1.Value);
            e1.Value = Math.Sqrt(val).ToString();
            return e1;
        }
    }
}
