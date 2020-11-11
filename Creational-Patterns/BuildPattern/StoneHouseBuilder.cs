using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class StoneHouseBuilder : IBuilder
    {
        private StoneHouse house;

        public StoneHouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.house = new StoneHouse();
        }

        public void SetDoors(int doors)
        {
            this.house.Door = doors;
        }

        public void SetGarden(bool isGarden)
        {
            this.house.IsGarden = isGarden;
        }

        public void SetType(string type)
        {
            this.house.Type = type;
        }

        public void SetWindows(int windows)
        {
            this.house.Window = windows;
        }

        public StoneHouse GetHouse()
        {
            StoneHouse stoneHouse = this.house;
            this.Reset();
            return stoneHouse;
        }
    }
}
