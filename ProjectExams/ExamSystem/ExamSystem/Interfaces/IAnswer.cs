using ExamSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Interfaces
{
    public interface IAnswer
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
    }
}
