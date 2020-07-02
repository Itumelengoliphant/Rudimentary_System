using System;
using static System.Console;
using static System.Convert;

namespace RudimentarySystem
{
    class Program : IMathOperations<int>
    {
        private static HelperClass helper;
        private static Student student;
        private static int count = 1;

        static int x, y, numOfQuest, contrVar = 0;
        static string userResponse = "";

        static Random random;
        static int num1, num2;

        static void Main(string[] args)
        {
            if (args != null)
            {
                int index = 0;

                Initialize();

                UserDisplay();

                helper.DisplayMessage($"Please enter your Name: ");
                student.Name = ReadLine();

                helper.DisplayMessage($"\nPlease enter your last Name: ");
                student.Surname = ReadLine();

                helper.DisplayMessage($"\n{UserModeSelection()}");
                student.Mode = ToInt32(ReadLine());

                helper.DisplayMessage($"\n{NumberOfQuestionsSelected()}");
                student.NumOfQuestSelected = ToInt32(ReadLine());
                numOfQuest = student.NumOfQuestSelected;


                helper.DisplayMessage("$\nPlease select your grade:\nGrade 1\nGrade 2\nGrade 3\nGrade 12");
                int user_response = ToInt32(ReadLine());

                switch (user_response)
                {
                    case 1:
                        RedirectToSelectedOption(1);
                        break;

                    case 2:
                        RedirectToSelectedOption(2);
                        break;

                    case 3:
                        RedirectToSelectedOption(3);
                        break;

                    case 4:
                        RedirectToSelectedOption(12);
                        break;

                    default:
                        break; ;
                }

                helper.DisplayMessage($"\nPlease select your desired operation:");

                foreach (int i in Enum.GetValues(typeof(Operation)))
                {
                    helper.DisplayMessage($"{Enum.GetName(typeof(Operation), i)}");

                    index = i;
                }

                RetrieveUserSelectedOption(ToInt32(ReadLine()));

                switch (student.Mode)
                {
                    case 1:
                        OnDetailsCaptured(student);
                        GradeInspector(student.GradeLevel);
                        break;

                    case 2:
                        OnDetailsCaptured(student);
                        GradeInspector(student.GradeLevel);
                        break;

                     default:
                        break;
                }
            }
        }
        static void Initialize()
        {
            helper = new HelperClass();
            student = new Student();
            random = new Random();
        }

        static void UserDisplay()
        {
            helper.DisplayMessage($"\n\n=========================================\n\n" +
                $"Good day, welcome to our classes\n\nThis programme is to assist\n" +
                $"You in mathematics from grade5 - 12: Please enjoy!!!\n\n");
        }

        static string UserModeSelection()
        {
            return helper.GetMessage($"\nPlease select the mode you'd like to attempt...\n" +
                 $"1:Practice Mode\n2:Test Mode\n3:Exit");
        }

        static string NumberOfQuestionsSelected()
        {
            return helper.GetMessage($"Enter the number of questions you'd like to take:");
        }

        static string OnGradeSelection(string gradeCaptured)
        {

            switch (Enum.GetName(typeof(Grade), 3))
            {
                case "Grade1":
                    gradeCaptured = "Grade 1 (Sub A)";
                    break;

                case "Grade2":
                    gradeCaptured = "Grade 2 (Sub B)";
                    break;

                case "Grade3":
                    gradeCaptured = "Grade 3 (Standard 1)";
                    break;

                case "Grade12":
                    gradeCaptured = "Grade 12 (Matric)";
                    break;

                default:
                    // throw new Exception("Error: Unknown Selection!");
                    break;
            }

            return gradeCaptured;
        }

        static string OnGradeSelection(Grade grades) =>

            grades switch

            {
                Grade.Grade1 => "Grade 1 (Sub A)",
                Grade.Grade2 => "Grade 2 (Sub B)",
                Grade.Grade3 => "Grade 3 (Standard 1)",
                Grade.Grade12 => "Grade 12 (Matric)",
                _ => throw new ArgumentException(message: "invalid enum value",
                                 paramName: nameof(grades)),

            };

        private static void RedirectToSelectedOption(int index)
        {

            if (index >= 0)
            {
                if (index == 1)
                {
                    student.GradeLevel = Grade.Grade1;
                }
                else if (index == 2)
                {
                    student.GradeLevel = Grade.Grade2;
                }
                else if (index == 3)
                {
                    student.GradeLevel = Grade.Grade3;
                }
                else if (index == 4)
                {
                    student.GradeLevel = Grade.Grade12;
                }
            }
        }

        private static void RetrieveUserSelectedOption(int response)
        {
            if (response == 1) { student.OperationSelection = Operation.Subtraction; }
            else if (response == 2) { student.OperationSelection = Operation.Addition; }
            else if (response == 3) { student.OperationSelection = Operation.Division; }
            else if (response == 4) { student.OperationSelection = Operation.Multiplication; }

        }

        public static void OnDetailsCaptured(Student student)
        {
            helper.DisplayMessage($"\n<<Confirmation of your details below>>:\n-------------------------------------------\nName\t\t: \t{student.Name}\nSurname\t\t: \t{student.Surname}\n" +
                      $"Mode\t\t: \t{student.Mode}\nQuestions\t: \t{student.NumOfQuestSelected}\nGrade\t\t: " +
                      $"\t{student.GradeLevel}\nOperation\t: \t{student.OperationSelection}");
        }

        public static void GradeInspector(Grade grade)
        {
            if (grade == Grade.Grade1)
            {
                //Level.GenerateRandomComputation(student.NumOfQuestSelected, student.Response, student.Current_Question);
                AdditionHelper();
            }
            else if (grade == Grade.Grade2)
            {
                Level.Grade_2();
            }
            else if (grade == Grade.Grade3)
            {
                Level.Grade_3();
            }
            else if (grade == Grade.Grade12)
            {
                Level.Grade_12();
            }
        }

        public static char ResponseCaptured()
        {
            char res;

            helper.DisplayMessage($"Would you like to continue?");
            res = ToChar(ReadLine());

            return res;
        }

        public static int Addition(char response, int currQues, int numOfQuest)
        {
            if (student.GradeLevel == Grade.Grade1)
            {

                do
                {
                    count++;

                    num1 = random.Next(0, 9);
                    num2 = random.Next(0, 9);

                    helper.DisplayMessage($"\n\n{num1} \n+ \n{num2} \n={num1 + num2}");


                } while (response.ToString().Equals('y'));
                
            }
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Division(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Multiplication(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int Average(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public static int AdditionHelper()
        {
            do
            {
                Random random = new Random();

                x = random.Next(0, 9);
                y = random.Next(0, 9);

                contrVar++;

                if (contrVar > 1)
                {
                    helper.DisplayMessage("\nWould you like to continue?");
                    userResponse = ReadLine();
                }

                if (userResponse.Equals(""))
                {
                    userResponse += string.Format("y");
                }


                Write($"\n\n-------------------------\n" +
                    $"Question {contrVar}\n-------------------------\n{x}");
                for (int i = 0; i < x; i++)
                {
                    Write("  o");
                }

                helper.DisplayMessage("\n+");

                Write($"{y}");
                for (int i = 0; i < y; i++)
                {
                    Write("  o");
                }

                WriteLine();

                Write($"={x + y}");
                for (int i = 0; i < x + y; i++)
                {
                    Write(" o");
                }

                if (contrVar >= numOfQuest || (!(userResponse.Equals("y"))))
                {
                    helper.DisplayMessage("\n\n<<End of session, Thank you>>");
                    break;
                }

            } while (userResponse.Equals("y"));

            return x + y;
        }
    }

}
