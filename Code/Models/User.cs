using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Models
{
    public class User
    {
        public int Id { get; set; }
        public List<Exercise> Exercises { get; set; }
        public long ChatId { get; set; }
    }
}