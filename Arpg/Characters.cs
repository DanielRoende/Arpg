namespace Arpg
{


    public class Characters
    {
        public static List<string> _chars = new List<string>();
        public enum CharClass
        {
            Mage,
            Amazon,
            Barbarian,
            Druid,
            Spellslinger,
            Necromancer,
            Scion,
            Preist

        }

        public class ShowMenu
        {

            public static void Menu()
            {

                Console.WriteLine("Chose your Character\n");
                Console.ReadKey();
                int selectClass = ConsoleNav.Navigation(true, CharClass.Mage.ToString(), CharClass.Amazon.ToString(), CharClass.Barbarian.ToString(), CharClass.Druid.ToString(), CharClass.Spellslinger.ToString(),
                    CharClass.Necromancer.ToString(), CharClass.Scion.ToString(), CharClass.Preist.ToString());

                var getNameOfEnum = Enum.GetName(typeof(CharClass), selectClass);
                Console.WriteLine("Chose a Name");
                while (true)
                {
                    string? nameof = Console.ReadLine();
                    if (nameof.All(nameof => char.IsLetterOrDigit(nameof)))
                    {
                        _chars.Add(getNameOfEnum.ToString() + " " + nameof);
                        break;
                    }
                    else if (nameof.All(nameof => !char.IsLetterOrDigit(nameof)))
                    {
                        Console.WriteLine("Try again");

                        nameof.All(nameof => char.IsLetterOrDigit(nameof));
                        nameof = Console.ReadLine();
                        


                    }
                }

            }

        }

        //loop this for extra party members
        public static void PartyMembers()
        {
            Console.WriteLine("Chose another partymember\n");
            Console.ReadKey();
            int selectClass = ConsoleNav.Navigation(true, CharClass.Mage.ToString(), CharClass.Amazon.ToString(), CharClass.Barbarian.ToString(), CharClass.Druid.ToString(), CharClass.Spellslinger.ToString(),
                            CharClass.Necromancer.ToString(), CharClass.Scion.ToString(), CharClass.Preist.ToString());
            var getNameOfEnum = Enum.GetName(typeof(CharClass), selectClass);
            Console.WriteLine("Chose a Name");

            while (true)
            {
                string? nameof = Console.ReadLine();
                if (nameof.All(nameof => char.IsLetterOrDigit(nameof)))
                {
                    _chars.Add(getNameOfEnum.ToString() + " " + nameof);
                    break;
                }
                else if (nameof.All(nameof => !char.IsLetterOrDigit(nameof)))
                {
                    Console.WriteLine("Try again");

                    nameof.All(nameof => char.IsLetterOrDigit(nameof));
                    nameof = Console.ReadLine();


                }
            }



            //   var getNameOfEnum = Enum.GetName(typeof(CharClass), selectClass);
            // _chars.Add(getNameOfEnum.ToString());
            //Console.WriteLine(String.Join("\n", _chars));
            //Console.ReadKey();
        }

    }
}

