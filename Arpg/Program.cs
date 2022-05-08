namespace Arpg
{
    public class Start
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hell -  pick a class and 4 team members");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            Console.Clear();
            Characters.ShowMenu.Menu();
            BaseCharacterStats.StatsRoll();
        }
    }
}