using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class VictorianChair : IChair
    {
        public string Style()
        {
            return "Victorian chair";
        }
    }
}
