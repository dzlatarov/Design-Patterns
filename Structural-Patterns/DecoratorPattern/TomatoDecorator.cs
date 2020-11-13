using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            var type = base.GetPizzaType();
            type += "\r\n with extra tomatoes";
            return type;
        }
    }
}
