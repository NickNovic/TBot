using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Code.Controllers
{
    public class BehaveController
    {
        public static async Task<Message> ReactToMesage(Message message)
        {
            TelegramBotClient client = new TelegramBotClient(Singletones.GlobalValues.Token);
            string text = "";
            if(message == null)
                return await Task.FromResult(new Message());
            
            if(message.Text != null)
                text = message.Text;

            switch(text.ToLower())
            {
                case "/start":
                    return await StartBot(message);
                
            }
            return await Task.FromResult(new Message());
        }

        public static async Task<Message> StartBot(Message message)
        {
            TelegramBotClient client = new TelegramBotClient(Singletones.GlobalValues.Token);

            var rkm = MenuController.GetStartupMenu();
            var startingText = TextController.GetStartupText();
            UserController.RegisterUser(message);
            

            return await client.SendTextMessageAsync(message.Chat.Id, startingText, replyMarkup: rkm);
        }
    }
}