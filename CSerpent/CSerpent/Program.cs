using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSerpent
{

    class Program
    {

        static void Main(string[] args)
        {
            const int MAX_DAMMAGE = 4;
            const int MIN_SIZE = 3;
            const int MAX_SIZE = 11;
            const int DEATH_SIZE = 0;
            Random rnd = new Random();
            Snek s1 = new Snek(rnd.Next(MIN_SIZE, MAX_SIZE));
            Snek s2 = new Snek(rnd.Next(MIN_SIZE, MAX_SIZE));

            ShowSneks(s1, s2);

            while (s1.Size > DEATH_SIZE && s2.Size > DEATH_SIZE)
            {
                int damage = rnd.Next(MAX_DAMMAGE);
                s1.Attack(s2, damage);
                Console.WriteLine($"Le serpent 1 attaque le serpent 2 pour {damage} degats");

                ShowSneks(s1, s2);

                damage = rnd.Next(MAX_DAMMAGE);
                s2.Attack(s1, damage);
                Console.WriteLine($"Le serpent 2 attaque le serpent 1 pour {damage} degats");

                ShowSneks(s1, s2);
            }

            Console.WriteLine("Ils sont morts");
        }

        static void ShowSneks(Snek s1, Snek s2)
        {
            Console.WriteLine("Le serpent 1 " + s1.Show());
            Console.WriteLine("Le serpent 2 " + s2.Show());
            Console.WriteLine("");
        }
    }
}
