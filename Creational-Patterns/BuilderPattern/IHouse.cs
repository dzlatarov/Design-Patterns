﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IHouse
    {
        int Door { get; }

        int Window { get; }

        bool IsGarden { get; }

        string Type { get; }
    }
}
