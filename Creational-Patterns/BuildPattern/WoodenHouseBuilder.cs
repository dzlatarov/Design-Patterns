using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class WoodenHouseBuilder : IBuilder
    {
        private WoodenHouse house;

        public WoodenHouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.house = new WoodenHouse();
        }

        public void SetDoors(int doors)
        {
            this.house.Door = doors;
        }

        public void SetGarden(bool IsGarden)
        {
            this.house.IsGarden = IsGarden;
        }

        public void SetType(string type)
        {
            this.house.Type = type;
        }

        public void SetWindows(int windows)
        {
            this.house.Window = windows;
        }

        public WoodenHouse GetHouse()
        {
            WoodenHouse WoodenHouse = this.house;
            this.Reset();
            return WoodenHouse;
        }
    }
}
