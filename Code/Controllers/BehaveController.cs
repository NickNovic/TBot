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
            //Переписать на получение нормальных кнопок из отдельного контроллера

            var rkm = new ReplyKeyboardMarkup(new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{
                        new KeyboardButton("АДЫН"), new KeyboardButton("ДУА")},
                    new List<KeyboardButton>{
                        new KeyboardButton("ТРЫ"), new KeyboardButton("ЧЫТЫРЫ")}
                });
            return await client.SendTextMessageAsync(message.Chat.Id, "STARTING TEXT", replyMarkup: rkm);
        }
    }
}