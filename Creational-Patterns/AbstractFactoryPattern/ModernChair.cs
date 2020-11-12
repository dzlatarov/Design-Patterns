using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernChair : IChair
    {
        public string Style()
        {
            return "Modern chair";
        }
    }
}
