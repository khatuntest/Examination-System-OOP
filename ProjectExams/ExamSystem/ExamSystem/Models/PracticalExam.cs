using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("=========== Practical Exam ==========");
            int QesNum = 1;
            foreach (var q in Questions) {
                Console.Write($"Q{QesNum} :");
                q.ShowQuestion();
                int attempts = 0,ans=-1;
                bool valid = false;
                while (attempts < 3)
                {
                    Console.WriteLine("Please Enter you answer number");
                    string temp = Console.ReadLine();
                    if(int.TryParse(temp, out ans))
                    {
                        if(ans > 0 && ans <= q.AnswerList.Length)
                        {
                            valid = true;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The Answer out of Range");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Answer , Please Enter Number of Answer");
                        Console.ResetColor();
                    }
                    attempts++;
                    if(attempts < 3)
                    {
                        Console.WriteLine($"You have {3-attempts} attempts left");
                    } 
                }
                if (!valid)
                {
                    Console.WriteLine("You Lose this Question , Moving to Next Question");
                }
                else
                {
                    Console.WriteLine($"Correct Answer is : {q.CorrectAnswer.AnswerText}.");
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                QesNum++;
            }
        }
    }
}
