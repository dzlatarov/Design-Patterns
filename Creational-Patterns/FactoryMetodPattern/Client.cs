using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMetodPattern
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientNode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientNode(new ConcreteCreator2());
        }

        public void ClientNode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
               "but it still works.\n" + creator.SomeOperation());
        }
    }
}
