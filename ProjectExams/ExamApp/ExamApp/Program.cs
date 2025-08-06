using ExamSystem.Interfaces;
using ExamSystem.Models;
using ExamSystem;
namespace ExamApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("============================= Welcome to Exam App ============================");
        bool TakeExam = true;
        while (TakeExam)
        {
            int sub = 0;
            while (true)
            {
                Console.WriteLine("Please Choose The Subject Number : ");
                Console.WriteLine("1. General.");
                Console.WriteLine("2. Programing.");
                Console.WriteLine("Please Enter 1 or 2.");
                string temp = Console.ReadLine();
                if (int.TryParse(temp, out sub) && (sub == 1 || sub == 2))
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is invalid input ,Try again!!");
                Console.ResetColor();
            }
            Subject s;
            if (sub == 1)
            {
                s = new Subject(1, "General");
            }
            else
            {
                s = new Subject(2, "Programming");
            }
            int typeExam = 0;
            while (true)
            {
                Console.WriteLine("Please Choose The Exam Type : ");
                Console.WriteLine("1. Final Exam.");
                Console.WriteLine("2. Practical Exam.");
                Console.WriteLine("Please Enter 1 or 2.");
                string temp = Console.ReadLine();
                if (int.TryParse(temp, out typeExam) && (typeExam == 1 || typeExam == 2))
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is invalid input ,Try again!!");
                Console.ResetColor();
            }

            s.CreateExam(typeExam);

            if (s.Exam != null)
                s.Exam.ShowExam();
            else
            {
                Console.WriteLine("Exam Creation Failed");
            }
            Console.WriteLine("Do You want to take another exam (write y or n)");
            string again =Console.ReadLine()?.Trim().ToLower();
            if(again != null && again[0] != 'y')
            {
                TakeExam = false;
            }
            Console.WriteLine("=================================================================================================");
        }

        Console.WriteLine("============================ With The Best Wishes. ===========================");
    }
}
