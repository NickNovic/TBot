using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Models
{
    public class Exercise 
    {
        public int Id { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
    }
}