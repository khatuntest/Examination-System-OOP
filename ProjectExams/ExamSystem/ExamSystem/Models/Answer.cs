using ExamSystem.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class Answer : IAnswer
    { 
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public Answer(int Id , string ans) {
            AnswerID = Id;
            AnswerText = ans;
            
        }
        public override string ToString()
        {
            return AnswerText;
        }

    }
}
