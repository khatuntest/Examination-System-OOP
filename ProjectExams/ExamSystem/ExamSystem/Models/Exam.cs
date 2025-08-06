using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Interfaces;

namespace ExamSystem.Models
{
    public abstract class Exam : IExam
    {  
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public IQuestion[] Questions { get; set; }

        public abstract void ShowExam();
    }
}
