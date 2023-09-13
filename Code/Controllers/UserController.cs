using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Models;
using Telegram.Bot.Types;
using Code.Repositories;

namespace Code.Controllers
{
    public class UserController
    {
        public static void RegisterUser(Message message)
        {
            UserRepository repository = new UserRepository();
            repository.Add(new Models.User{
                Exercises = new List<Exercise>{},
                ChatId = message.Chat.Id
            });
        }
    }
}