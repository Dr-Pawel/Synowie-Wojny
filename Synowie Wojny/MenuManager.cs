using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synowie_Wojny
{

    internal class MenuManager
    {
        static string title = @"
             _______  _______  _        _______      _______  _______             _______  _______ 
            (  ____ \(  ___  )( (    /|(  ____ \    (  ___  )(  ____ \  |\     /|(  ___  )(  ____ )
            | (    \/| (   ) ||  \  ( || (    \/    | (   ) || (    \/  | )   ( || (   ) || (    )|
            | (_____ | |   | ||   \ | || (_____     | |   | || (__      | | _ | || (___) || (____)|
            (_____  )| |   | || (\ \) |(_____  )    | |   | ||  __)     | |( )| ||  ___  ||     __)
                  ) || |   | || | \   |      ) |    | |   | || (        | || || || (   ) || (\ (   
            /\____) || (___) || )  \  |/\____) |    | (___) || )        | () () || )   ( || ) \ \__
            \_______)(_______)|/    )_)\_______)    (_______)|/         (_______)|/     \||/   \__/  
            ";
        static string newGame = @"
              _
             / |      _ _    ___  __ __ __    __ _   __ _   _ __    ___ 
             | |  _  | ' \  / -_) \ V  V /   / _` | / _` | | '  \  / -_)
             |_| (_) |_||_| \___|  \_/\_/    \__, | \__,_| |_|_|_| \___|
                                             |____|
            ";
        static string loadGame = @"
              ___       _                      _      ___                      
             |_  )     | |     ___   __ _   __| |    / __|  __ _   _ __    ___ 
              / /   _  | |__  / _ \ / _` | / _` |   | (_ | / _` | | '  \  / -_)
             /___| (_) |____| \___/ \__,_| \__,_|    \___| \__,_| |_|_|_| \___|
            ";
        static string options = @"
             ____       ___           _     _                   
            |__ /      / _ \   _ __  | |_  (_)  ___   _ _    ___
             |_ \  _  | (_) | | '_ \ |  _| | | / _ \ | ' \  (_-<
            |___/ (_)  \___/  | .__/  \__| |_| \___/ |_||_| /__/
                              |_|               
            ";
        static string exit = @"
             _ _        ___         _   _   
            | | |      | __| __ __ (_) | |_ 
            |_  _|  _  | _|  \ \ / | | |  _|
              |_|  (_) |___| /_\_\ |_|  \__| 
            ";

        public void DrawMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(newGame);
            Console.WriteLine(loadGame);
            Console.WriteLine(options);
            Console.WriteLine(exit);
            Console.WriteLine("\n");
            Console.WriteLine("Advice : Type the number of option you want to use");

            Console.ResetColor();

        }
        public void ChooseMainMenu()
        {
            string playerInput = Console.ReadLine();

            if (playerInput == "1")
            {
                Console.Clear();
                StartNewGame();
            }
            else if (playerInput == "2")
            {
                Console.Clear();
                Console.WriteLine("load Game");
            }
            else if (playerInput == "3")
            {
                Console.Clear();
                Console.WriteLine("Options");
            }
            else if (playerInput == "4")
            {
                Console.Clear();
                Environment.Exit(1);
            }
        }
        private void StartNewGame()
        {
            Console.Clear();
            Player player = new Player();

            #region race
            Console.WriteLine("hello new warrior, please tell me what race are you");
            string raceChoice;
            do
            {
                WriteColored("Choose race:\n 1. Orc\n 2. Troll\n 3. Tauren", ConsoleColor.Blue);
                raceChoice = Console.ReadLine();
            }
            while (raceChoice != "1" && raceChoice != "2" && raceChoice != "3");

            if (raceChoice == "1")
            {
                player.Race = "Orc";
            }
            else if (raceChoice == "2")
            {
                player.Race = "Troll";
            }
            else if (raceChoice == "3")
            {
                player.Race = "Tauren";
            }
            WriteColored($"race chosen : {player.Race}", ConsoleColor.Yellow);
            Console.ResetColor();
            #endregion

            #region name
            string nameChoice;
            Console.WriteLine("Now, please tell me, what is your name?");
            WriteColored("Name:", ConsoleColor.Blue);
            nameChoice = Console.ReadLine();

            player.Name = nameChoice;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"name chosen : {player.Name}");
            Console.ResetColor();
            #endregion

            #region age
            int age;
            Console.WriteLine("And i also need to know, how old are you");
            WriteColored("Age:", ConsoleColor.Blue);

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                WriteColored("Please enter a valid number!", ConsoleColor.Red);
            }
            player.Age = age;
            WriteColored($"You are {player.Age} old", ConsoleColor.Yellow);
            Console.ResetColor();
            #endregion
        }

        private void WriteColored(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

    }
}
