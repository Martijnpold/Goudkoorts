﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts.Model
{
    public class Map : IScoreHolder
    {
        public Tile Corner { get; set; }

        public List<SpawnTrack> Spawns { get; set; }
        public List<TrackBase> RailEnds { get; set; }
        public List<JunctionBase> Junctions { get; set; }
        public int Score { get; set; }
        public bool GameOver { get; set; }

        public River RiverEnd { get; set; }

        public Map()
        {
            Spawns = new List<SpawnTrack>();
            RailEnds = new List<TrackBase>();
            Junctions = new List<JunctionBase>();
        }

        public int GetScore()
        {
            return Score;
        }

        public void AddScore(int score)
        {
            Score += score;
        }
    }
}