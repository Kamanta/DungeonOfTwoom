using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfTwoom.Properties
{
    class Stats
    {
        public int maxHP { get; set; }
        public int currentHP { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int dexterity { get; set; }
        public int charisma { get; set; }
        public int constitution { get; set; }

        public int takeDamage(int currentHP, int damage)
        {
            currentHP = currentHP - damage;
            if (currentHP < 0)
            { currentHP = 0; }
            return currentHP;
        }

        public int healHP(int currentHP, int healing)
        {
            currentHP = currentHP + healing;
            if (currentHP > maxHP)
            { currentHP = maxHP; }
            return currentHP
        }
    }

      
}
