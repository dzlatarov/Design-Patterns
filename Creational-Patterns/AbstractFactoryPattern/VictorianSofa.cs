using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class VictorianSofa : ISofa
    {
        public string Print(IChair collaborator)
        {
            var result = collaborator.Style();

            return $"The result of the VictorianSofa colaborating with the ({result})";
        }

        public string Type()
        {
            return "Victorian sofa";
        }
    }
}
