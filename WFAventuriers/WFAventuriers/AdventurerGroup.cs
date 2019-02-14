using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAventuriers
{
    class AdventurerGroup
    {
        Random rnd;
        string[] syllables;

        Adventurer archer;
        Adventurer warrior;
        Adventurer magician;
        Adventurer priest;

        internal Adventurer Archer { get => archer; set => archer = value; }
        internal Adventurer Warrior { get => warrior; set => warrior = value; }
        internal Adventurer Magician { get => magician; set => magician = value; }
        internal Adventurer Priest { get => priest; set => priest = value; }

        

        public AdventurerGroup()
        {
            rnd = new Random();

            syllables = new string[] { "mai", "ou", "es", "donk", "or", "ni", "car" };

            Archer = new Adventurer(GetRandomName(), rnd.Next(40, 81));
            Warrior = new Adventurer(GetRandomName(), rnd.Next(80, 101));
            Magician = new Adventurer(GetRandomName(), rnd.Next(20, 41));
            Priest = new Adventurer(GetRandomName(), rnd.Next(30, 61));
        }

        

        public void GameOver()
        {
            Archer.Die();
            Warrior.Die();
            Magician.Die();
            Priest.Die();
        }

        public string GetRandomName()
        {
            string name = syllables[rnd.Next(syllables.Length)] + syllables[rnd.Next(syllables.Length)];
            string nameWithFirstLetterCapital = name.First().ToString().ToUpper() + name.Substring(1);

            return nameWithFirstLetterCapital;
        }
    }
}
