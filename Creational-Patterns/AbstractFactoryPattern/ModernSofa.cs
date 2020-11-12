using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ModernSofa : ISofa
    {
        public string Print(IChair collaborator)
        {
            var result = collaborator.Style();
            return $"The result of the Modern sofa is colaborating with the ({result})";
        }

        public string Type()
        {
            return "Modern type Sofa";
        }
    }
}
