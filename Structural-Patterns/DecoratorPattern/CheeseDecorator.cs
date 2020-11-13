using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n with extra cheese";
            return type;
        }
    }
}
