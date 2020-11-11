namespace BuilderPattern
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var director = new Director();

            StoneHouseBuilder stoneBuilder = new StoneHouseBuilder();
            director.ConstructorStoneHouse(stoneBuilder);
            StoneHouse stoneHouse = stoneBuilder.GetHouse();

            WoodenHouseBuilder woodBuilder = new WoodenHouseBuilder();
            director.ConstructorWoodenHouse(woodBuilder);
            WoodenHouse woodHouse = woodBuilder.GetHouse();
        }
    }
}
