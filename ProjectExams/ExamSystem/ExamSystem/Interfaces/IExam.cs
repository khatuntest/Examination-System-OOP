using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Interfaces
{
    public interface IExam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public IQuestion[] Questions{ get; set; }
        public void ShowExam();
    }
}
