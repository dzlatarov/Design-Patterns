using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class StoneHouse : IHouse
    {
        public StoneHouse()
        {

        }

        public int Door { get; set; }

        public int Window { get; set; }

        public bool IsGarden { get; set; }

        public string Type { get; set; }
    }
}
