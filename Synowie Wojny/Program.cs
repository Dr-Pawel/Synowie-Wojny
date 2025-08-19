using System.Threading.Channels;

namespace Synowie_Wojny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 50);
            Console.SetWindowSize(200, 50);

            MenuManager menuManager = new MenuManager();
            menuManager.DrawMainMenu();
            menuManager.ChooseMainMenu();

            Console.ReadKey();
        }
    }
}
