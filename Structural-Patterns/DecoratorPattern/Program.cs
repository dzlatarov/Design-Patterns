using System;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza cheesePizza = new CheeseDecorator(pizza);
            IPizza tomatoPizza = new TomatoDecorator(cheesePizza);
            IPizza salamiPizza = new SalamiDecorator(tomatoPizza);
            Console.WriteLine(salamiPizza.GetPizzaType());
        }
    }
}
