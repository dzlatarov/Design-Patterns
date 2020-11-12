using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();

        ISofa CreateSofa();
    }
}
