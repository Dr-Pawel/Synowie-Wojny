using System.Threading.Channels;

namespace Synowie_Wojny
{
    internal class Program
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
                                             |___
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

        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 50);
            Console.SetWindowSize(200, 50);

            DrawMainMenu();
            ChooseMainMenu();
            Console.ReadKey();
        }

        static void DrawMainMenu()
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
        static void ChooseMainMenu()
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

        static void StartNewGame()
        {
            Console.Clear();
            Player player = new Player();
            Console.WriteLine("hello new warrior, please tell me what race are you");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" 1.Orc \n 2.Troll \n 3.Tauren");
            string playerInput = Console.ReadLine();
            if(playerInput == "1")
            {
                player.Race = "Orc";
            }
            else if(playerInput == "2")
            {
                player.Race = "Troll";
            }
            else if(playerInput == "3")
            {
                player.Race = "Tauren";
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"race chosen : {player.Race}");
            Console.ResetColor();
            Console.WriteLine("Now, please tell me, what is your name?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Name:");
            playerInput = Console.ReadLine();

            player.Name = playerInput;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"name chosen : {player.Name}");
            Console.ResetColor();

            Console.WriteLine("And i also need to know, how old are you");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Age:");

            playerInput = Console.ReadLine();

            player.Age = int.Parse(playerInput);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You are {player.Age} old");
            Console.ResetColor();


        }
    }
}
