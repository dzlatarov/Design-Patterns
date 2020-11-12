using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface ISofa
    {
        string Type();

        string Print(IChair collaborator);
    }
}
