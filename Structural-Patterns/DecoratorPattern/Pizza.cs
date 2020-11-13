using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "Normal pizza";
        }
    }
}
