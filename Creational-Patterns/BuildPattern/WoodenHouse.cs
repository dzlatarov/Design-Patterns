using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public class WoodenHouse : IHouse
    {
        public WoodenHouse()
        {

        }

        public int Door { get; set; }

        public int Window { get; set; }

        public bool IsGarden { get; set; }

        public string Type { get; set; }
    }
}
