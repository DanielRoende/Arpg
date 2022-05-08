namespace Arpg
{

    public class BaseLife
    {
        public int hp = 100;
    }
    public class MobsBaseModifiers
    {
        public int Speed;
        public int MaxSpeed;
        public int MinSpeed;

    }
    public class MobsModPool
    {
        //CC = Freze, Stun, Slow
        //Dmg Mods = Extra dmg, Lightning, Fire, Cold, Phys
        //Life Mods = Extra life 
    }
    public class BaseCharacterStats : Characters
    {
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }


        public static void StatsRoll()
        {
            for (int i = 0; i <= 3;)
            {
                int yes = 0;
                int no = 1;
                ConsoleKey key;
                key = Console.ReadKey(true).Key;

                Console.WriteLine("Now you roll your Base Stats");
                Console.ReadKey();
                Random random = new Random();
                BaseCharacterStats bStats = new BaseCharacterStats();
                bStats.Dexterity = random.Next(5, 15);
                bStats.Intelligence = random.Next(5, 15);
                bStats.Strength = random.Next(5, 15);
                Console.WriteLine("\nDexterity = " + bStats.Dexterity);
                Console.WriteLine("Intelligence= " + bStats.Intelligence);
                Console.WriteLine("Strength= " + bStats.Strength);
                Console.WriteLine("\nReroll?\nPress 0 to reroll and 1 to continue");
                Console.ReadKey();
                int selectClass = ConsoleNav.Navigation(true, yes.ToString(), no.ToString());
                if (selectClass == 0)
                {
                    StatsRoll();
                }
                else if (selectClass == 1)
                {

                    Characters.PartyMembers();

                }

                i++;
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("This is your team! Prepare to fight!");
                    Console.WriteLine(String.Join("\n", _chars));
                    Console.ReadKey();
                }
            }
        }



    }

}
