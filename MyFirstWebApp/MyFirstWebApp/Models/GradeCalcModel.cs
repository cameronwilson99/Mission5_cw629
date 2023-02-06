using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class GradeCalcModel
    {
        // Defines getters and setters for each element of the form, validates that the number inputed is between 0 and 100.
        [Range(0,100, ErrorMessage = "Can only be between 0 and 100")]
        public int Assignments { get; set; }
        [Range(0, 100, ErrorMessage = "Can only be between 0 and 100")]
        public int GroupProject { get; set; }
        [Range(0,100, ErrorMessage = "Can only be between 0 and 100")]
        public int Quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Can only be between 0 and 100")]
        public int MidtermExam { get; set; }
        [Range(0, 100, ErrorMessage = "Can only be between 0 and 100")]
        public int FinalExam { get; set; }
        [Range(0, 100, ErrorMessage = "Can only be between 0 and 100")]
        public int INTEX { get; set; }
    }
}
