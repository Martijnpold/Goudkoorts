﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public abstract class Tile
    {
        public Dictionary<Direction, Tile> Neighbours { get; set; }

        public abstract char GetIcon();
    }
}
