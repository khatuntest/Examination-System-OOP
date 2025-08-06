using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Interfaces;

namespace ExamSystem.Models
{
    public class FinalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("=============  Final Exam ===============");
            int Score = 0,QusNum=1;
            for (int i = 0; i < Questions.Length; ++i)
            {
                Console.Write($"Q{QusNum}: ");
                var q = Questions[i];
                q.ShowQuestion();
                IAnswer userAnswer = null;
                int attempts = 0;
                bool check = false;
                while (attempts < 3)
                {
                    Console.WriteLine("Enter Your Answer Number :");
                    string temt = Console.ReadLine();
                    if (int.TryParse(temt, out int ansId))
                    {
                        if (ansId > 0 && ansId <= q.AnswerList.Length)
                        {
                            userAnswer = q.AnswerList[ansId - 1];
                            check = true;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Answer number is out of range");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid format , Please Enter number of Answer");
                        Console.ResetColor();
                    }
                    attempts++;
                    if (attempts < 3)
                    {
                        Console.WriteLine($"You have {3 - attempts} attempts left");
                    }
                }
                if (!check)
                {
                    Console.WriteLine("You Lose this Question , Moving to next Question");
                    Console.WriteLine("-------------------------------------------------------------");
                    QusNum++;
                    continue;
                }
                Console.WriteLine($"Your Answer is : " + userAnswer.AnswerText);
                Console.WriteLine($"The Correct Answer is :" + q.CorrectAnswer.AnswerText);
                if (userAnswer.AnswerID == q.CorrectAnswer.AnswerID)
                {
                    Score += q.Mark;
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
                 QusNum++;
                }
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Total Score is {Score}.");
            Console.ResetColor();
            
        }
    }
}
