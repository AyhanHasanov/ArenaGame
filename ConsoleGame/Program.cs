using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Play(Hero one, Hero two, int rounds)
        {
            int oneWins = 0, twoWins = 0;

            Console.WriteLine($"\nNEW FIGHT\n{one.Name} with weapon {one.Weapon.Name} ({one.Weapon.Damage}) " +
                $"vs {two.Name} with weapon {two.Weapon.Name} ({two.Weapon.Damage})\n");

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Round: {i + 1}/{rounds}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}\n");
                if (winner == one) oneWins++; else twoWins++;
            }

            Console.WriteLine(oneWins == twoWins ? $"Equal {oneWins}" : oneWins > twoWins ? $"{one.Name} WINS THE FIGHT WITH {oneWins} WINS\n{two.Name} has {twoWins} wins" : $"{two.Name} WINS THE FIGHT {twoWins} WINS\n{one.Name} has {oneWins} wins");
        }
        static void Main(string[] args)
        {
            
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());

            List<Weapon> weapons = new List<Weapon>()
            {
                new Sword(11),
                new Sword(15),
                new Axe(11, false),
                new Axe(11, true),
                new Bow(9)
            };

            Random rndm = new Random();
            List<Hero> heroes = new List<Hero>()
            {
                new Knight("Kinght Simon", weapons[rndm.Next(0, weapons.Count)]),
                new Knight("Kinght Olivia", weapons[rndm.Next(0, weapons.Count)]),
                new Mage("Mage Robin", weapons[rndm.Next(0, weapons.Count)]),
                new Mage("Mage Fire", weapons[rndm.Next(0, weapons.Count)]),
                new Archer("Archer Kevin", weapons[rndm.Next(0, weapons.Count)]),
                new Archer("Archer Anya", weapons[rndm.Next(0, weapons.Count)]),
                new Berserker("Berserker Savage", weapons[rndm.Next(0, weapons.Count)]),
                new Berserker("Berserker Grim", weapons[rndm.Next(0, weapons.Count)]),
                new Rogue("Rogue Lana", weapons[rndm.Next(0, weapons.Count)]),
                new Rogue("Rogue Del Rey", weapons[rndm.Next(0, weapons.Count)])
            };


            //foreach (var hero in heroes)
            //{
            //    Console.WriteLine($"{hero.Name} {hero.Weapon.Name} {hero.Weapon.Damage}");
            //}

            for (int i = 0; i < 3; i++)
            {
                Play(heroes[rndm.Next(0, heroes.Count)], heroes[rndm.Next(0, heroes.Count)], rounds);
                Console.WriteLine("\nPress any key to start another fight...");
                Console.ReadKey();
                Console.WriteLine("\n\n");
            }

            //for (int i = 0; i < rounds; i++)
            //{
            //    Hero one = new Knight("Kinght Simon", weapons.GetValueOrDefault("Ordinary axe"));
            //    Hero two = new Mage("Mage Robin", weapons.GetValueOrDefault("Ordinary sword"));
            //    Console.WriteLine(one.ToString());

            //    Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
            //    Arena arena = new Arena(one, two);
            //    Hero winner = arena.Battle();
            //    Console.WriteLine($"Winner is: {winner.Name}");
            //    if (winner == one) oneWins++; else twoWins++;
            //}

            //for (int i = 0; i < rounds; i++)
            //{
            //    Hero one = new Archer("Archer Vivian", weapons.GetValueOrDefault("Ordinary Bow"));
            //    Hero two = new Berserker("Robih Hood", weapons.GetValueOrDefault("Double-sided axe"));
            //    Console.WriteLine(one.ToString());

            //    Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
            //    Arena arena = new Arena(one, two);
            //    Hero winner = arena.Battle();
            //    Console.WriteLine($"Winner is: {winner.Name}");
            //    if (winner == one) oneWins++; else twoWins++;
            //}

            //Console.WriteLine();
            //Console.WriteLine($"One has {oneWins} wins.");
            //Console.WriteLine($"Two has {twoWins} wins.");
        }
    }
}
