using System.Threading.Tasks;
using System;
using Code.Singletones;
using Telegram.Bot;
using Telegram.Bot.Types;
using Code.Controllers;

namespace Code
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Server started");

            MainController controller = new MainController();
            await controller.StartMessageReciver();
        
            Console.ReadLine();
        }
    }
}