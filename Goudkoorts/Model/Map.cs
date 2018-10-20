﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class Map
    {
        public Tile Corner { get; set; }

        public List<SpawnTrack> Spawns { get; set; }
        public List<TrackBase> RailEnds { get; set; }
    }
}