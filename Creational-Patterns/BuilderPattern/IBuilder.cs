using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void Reset();

        void SetWindows(int windows);

        void SetDoors(int doors);

        void SetGarden(bool isGarden);

        void SetType(string type);
    }
}
