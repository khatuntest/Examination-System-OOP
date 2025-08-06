using ExamSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class TrueFalseQuestion : Question
    {
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}.                           ({Mark})");
            Console.WriteLine($"    {Body}");
            Console.WriteLine("1.True");
            Console.WriteLine("2.False");
        }
    }
}
