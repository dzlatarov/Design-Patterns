﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SalamiDecorator : PizzaDecorator
    {
        public SalamiDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            var type = base.GetPizzaType();
            type += "\r\n with extra salami";
            return type;
        }
    }
}
