using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonOfTwoom.Properties
{
    class Stats
    {
        public int maxHP { get; set; }
        public int currentHP { get; set; }
        public int tempHP { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int dexterity { get; set; }
        public int charisma { get; set; }
        public int constitution { get; set; }

        public int takeDamage(int damage)
        {
            this.currentHP = currentHP - damage;
            if (this.currentHP < 0)
            { this.currentHP = 0; }
            return this.currentHP;
        }

        public int healHP(int healing)
        {
            this.currentHP = currentHP + healing;
            if (this.currentHP > maxHP)
            { this.currentHP = maxHP; }
            return this.currentHP;
        }
    }

      
}
