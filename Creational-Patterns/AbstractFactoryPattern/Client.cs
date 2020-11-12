using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Client
    {
        public void Main()
        {
            ClientMethod(new ModernFurnitureFactory());
            ClientMethod(new VictorianFurnitureFactory());
        }


        public void ClientMethod(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();

            Console.WriteLine(sofa.Type());
            Console.WriteLine(sofa.Print(chair));
        }
    }
}
