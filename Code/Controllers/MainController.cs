using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Code.Controllers
{
    public class MainController
    {
        public string Token;
        public TelegramBotClient client;
        public MainController()
        {
            Token = Singletones.GlobalValues.Token;
            client = new TelegramBotClient(Token);
        }
        
        public async Task<int> StartMessageReciver()
        {
            Console.WriteLine("Reciver started");
            if(client == null){
                return await Task.FromResult(0);
            }
            client.StartReceiving(UpdateHandler, ErrorHandler);

            return await Task.FromResult(0);
        }

        private Task ErrorHandler(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            Console.WriteLine("Error");
            throw new NotImplementedException();
        }

        private async Task<int> UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
        {
            if(update.Message == null)
            {
                return 0;
            }

            var message = update.Message;
            
            await BehaveController.ReactToMesage(message);
            return 0;
        }
    }
}