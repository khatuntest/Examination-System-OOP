using ExamSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class MCQQuestion : Question
    {
       
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}.                           ({Mark})");
            Console.WriteLine($"    {Body}");
            if (AnswerList == null || AnswerList.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No answers available for this question.");
                Console.ResetColor();
                return;
            }
            for (int i=0; i<AnswerList.Length; ++i)
            {
                if (AnswerList[i] != null)
                {
                    Console.WriteLine($"{AnswerList[i].AnswerID}.{AnswerList[i].AnswerText}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning!!!!!!!!!!");
                    Console.WriteLine($"Question {Body} hasn't Answer List");
                    Console.ResetColor();
                }
            }
          
        }
    }
}
