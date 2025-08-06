using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Interfaces
{
    public interface IQuestion
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public IAnswer[] AnswerList { get; set; }
        public IAnswer CorrectAnswer { get; set; }
        public void ShowQuestion();

    }
}
