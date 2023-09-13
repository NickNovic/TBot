using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace Code.Controllers
{
    public class MenuController
    {
        public static ReplyKeyboardMarkup GetStartupMenu()
        {
            return new ReplyKeyboardMarkup(new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{
                        new KeyboardButton("АДЫН"), new KeyboardButton("ДУА")},
                    new List<KeyboardButton>{
                        new KeyboardButton("ТРЫ"), new KeyboardButton("ЧЫТЫРЫ")}
                });
        }
    }
}