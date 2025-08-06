using ExamSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Models
{
    public class Subject
    {
        
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Subject(int id , string name) {
            SubjectID = id;
            SubjectName = name;
        }

        public void CreateExam(int type)
        {
            try
            {

                if (SubjectID == 1)
                {//General
                    if (type == 1)//final
                    {
                        FinalExam final = new FinalExam();
                        final.TimeOfExam = 45;
                        final.NumberOfQuestions = 4;
                        final.Questions = new Question[] {
                    new MCQQuestion{
                        Header="Choose The Correct One :-",
                        Body ="2 + 2 = ",
                        Mark = 3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"4"),
                            new Answer(2,"6"),
                            new Answer(3,"9")

                        },
                        CorrectAnswer=new Answer(1,"4")
                    },
                    new MCQQuestion
                    {
                        Header="Choose The Correct One :-",
                        Body ="4 * 2 = ",
                        Mark=5,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"7"),
                            new Answer(2,"33"),
                            new Answer(3,"8")

                        },
                        CorrectAnswer=new Answer(3,"8")

                    },
                    new TrueFalseQuestion
                    {
                        Header="True or False :-",
                        Body = "J.K. Rowlling authored the famous Harry Potter book Series.",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"true"),
                            new Answer(2,"false")
                        },
                        CorrectAnswer=new Answer(1,"true")

                    },
                    new TrueFalseQuestion
                    {
                         Header="True or False :-",
                        Body = "Humans lose an average of 75 stands of hair per week.",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"true"),
                            new Answer(2,"false")
                        },
                        CorrectAnswer=new Answer(2,"false")

                    }
                };
                        ValidAnswers(final.Questions);
                        this.Exam = final;

                    }
                    else
                    {//practical
                        PracticalExam practical = new PracticalExam();
                        practical.TimeOfExam = 20;
                        practical.NumberOfQuestions = 2;
                        practical.Questions = new Question[] {
                    new MCQQuestion{
                        Header="Choose The Correct One :-",
                        Body ="5 * 6 = ",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"4"),
                            new Answer(2,"30"),
                            new Answer(3,"9")

                        },
                        CorrectAnswer=new Answer(2,"30")
                    },
                    new MCQQuestion
                    {
                        Header="Choose The Correct One :-",
                        Body ="10 - 35= ",
                        Mark=5,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"-25"),
                            new Answer(2,"33"),
                            new Answer(3,"8")

                        },
                        CorrectAnswer=new Answer(1,"-25")

                    }
                };
                        ValidAnswers(practical.Questions);
                        this.Exam = practical;
                    }

                }
                else//programing
                {
                    if (type == 1)//final
                    {
                        FinalExam final = new FinalExam();
                        final.TimeOfExam = 45;
                        final.NumberOfQuestions = 4;
                        final.Questions = new Question[] {
                    new MCQQuestion{
                        Header="Choose The Correct One :-",
                        Body ="Which of the following is not a valid C variable name?",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"float rate;"),
                            new Answer(2,"int variable_count;"),
                            new Answer(3,"int $main;")

                        },
                        CorrectAnswer=new Answer(3,"int $main;")
                    },
                    new MCQQuestion
                    {
                        Header="Choose The Correct One :-",
                        Body ="All keywords in C are in.......",
                        Mark=5,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"LowerCase letters"),
                            new Answer(2,"UpperCase letters"),
                            new Answer(3,"CamelCase letters")

                        },
                        CorrectAnswer=new Answer(1,"LowerCase letters")

                    },
                    new TrueFalseQuestion
                    {
                        Header="True or False :-",
                        Body = "Real is a java primitive type",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"true"),
                            new Answer(2,"false")
                        },
                        CorrectAnswer=new Answer(2,"false")

                    },
                    new TrueFalseQuestion
                    {
                         Header="True or False :-",
                        Body = "my Value is not a valid Java identifier.",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"true"),
                            new Answer(2,"false")
                        },
                        CorrectAnswer=new Answer(1,"true")

                    }
                };
                        ValidAnswers(final.Questions);
                        this.Exam = final;

                    }
                    else
                    {//practical
                        PracticalExam practical = new PracticalExam();
                        practical.TimeOfExam = 20;
                        practical.NumberOfQuestions = 2;
                        practical.Questions = new Question[] {
                    new MCQQuestion{
                        Header="Choose The Correct One :-",
                        Body ="5 * 6 = ",
                        Mark=3,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"4"),
                            new Answer(2,"30"),
                            new Answer(3,"9")

                        },
                        CorrectAnswer=new Answer(2,"30")
                    },
                    new MCQQuestion
                    {
                        Header="Choose The Correct One :-",
                        Body ="10 - 35= ",
                        Mark=5,
                        AnswerList = new Answer[]
                        {
                            new Answer(1,"-25"),
                            new Answer(2,"33"),
                            new Answer(3,"8")

                        },
                        CorrectAnswer=new Answer(1,"-25")

                    }
                };
                        ValidAnswers(practical.Questions);
                        this.Exam = practical;

                    } 
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred while creating the exam: " + ex.Message);
                Console.ResetColor();
            }
            
        }
        private void ValidAnswers(IQuestion[] questions)
        {
            foreach (var q in questions)
            {
                if (!q.AnswerList.Any(a => a.AnswerID == q.CorrectAnswer.AnswerID))
                {
                    throw new Exception($"Question '{q.Body}' has an invalid CorrectAnswer.");
                }
            }
        }

    }
}

