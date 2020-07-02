using System;
using System.Collections.Generic;
using System.Text;

namespace RudimentarySystem
{
    public static class Level
    {
        private static HelperClass helper = new HelperClass();
        private static Student student = new Student();

        public static void Grade_1()
        {
            //GenerateRandomComputation(student.NumOfQuestSelected, student.Response, student.Current_Question);
        }
        public static void Grade_2() { }

        public static void Grade_3() { }

        public static void Grade_12() { }

        static Random random = new Random();
        static int num1, num2, contr_var;
        public static void GenerateRandomComputation(int questions, string response, int currQues)
        {
            student.Current_Question = currQues;

            if (random != null)
            {
                num1 = random.Next(0, 9);
                num2 = random.Next(0, 9);

                do
                {
                    helper.DisplayMessage($"\n\n{num1} \n+ \n{num2} \n={num1 + num2}");
                    contr_var++;

                } while (response.Equals('y') && currQues <= questions);
            }
        }

    }
}
