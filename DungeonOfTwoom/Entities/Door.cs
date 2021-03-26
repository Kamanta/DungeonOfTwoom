using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfTwoom
{
    public class Door
    {
        public string description { get; set; }
        //public DoorType type { get; set; }
        public bool locked { get; set; }
        public DoorDirection direction { get; set; }
        public bool hidden { get; set; }
    }
}
