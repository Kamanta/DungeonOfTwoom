using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfTwoom
{
    class Monster
    {
        public string description { get; set; }
        public MonsterType type { get; set; }
        public Stats stats { get; set; }
        public string name { get; set; }
        public bool hidden { get; set; }
        public bool isAlive { get; set; }
        public MonsterState state { get; set; }
        public MonsterMind mindset { get; set }
    }
}
