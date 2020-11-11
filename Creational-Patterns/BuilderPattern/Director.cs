using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        private IBuilder builder;

        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructorStoneHouse(IBuilder builder)
        {
            builder.Reset();
            builder.SetDoors(2);
            builder.SetGarden(true);
            builder.SetType("Stone");
            builder.SetWindows(4);            
        }

        public void ConstructorWoodenHouse(IBuilder builder)
        {
            builder.Reset();
            builder.SetDoors(1);
            builder.SetGarden(false);
            builder.SetType("Wood");
            builder.SetWindows(4);
        }
    }
}
