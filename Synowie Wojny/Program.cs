using System.Threading.Channels;

namespace Synowie_Wojny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(200, 50);
            Console.SetWindowSize(200, 50);

            var menu = new MenuManager();
            var game = new GameManager();

            menu.DrawMainMenu();
            int choice = menu.ChooseMainMenu();

            if (choice == 1)
            {
                var playerData = menu.AskPlayerData();
                Player player = game.CreatePlayer(playerData.race, playerData.name, playerData.age);
                Console.WriteLine($"Created player: {player.Name} ({player.Race}), age {player.Age}");
            }
            else if (choice == 2)
            {
                // logika ładowania gry
            }
            else if (choice == 3)
            {
                // logika opcji
        }   
            Console.ReadKey();
        }
    }
}
