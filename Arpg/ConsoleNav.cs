namespace Arpg
{
    internal class ConsoleNav : Characters
    {
        // Remember to implement cancel
        public static int Navigation(bool cancelSelection, params string[] options)
        {
            const int startHorizontal = 0;
            const int startVertical = 0;
            const int optionsPerLine = 1;
            const int spacingPerLine = 14;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startHorizontal + (i % optionsPerLine) * spacingPerLine, startVertical + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }

                }
            } while (key != ConsoleKey.Enter);
            Console.Clear();
            var getNameOfEnum = Enum.GetName(typeof(CharClass), currentSelection);
            Console.WriteLine("Your Choice is \n" + getNameOfEnum);
            Console.Clear();
            Console.CursorVisible = true;
            return currentSelection;



        }

    }

}
