﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core.DiscountStrategies
{
    internal interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
