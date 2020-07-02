using System;
using System.Collections.Generic;
using System.Text;

namespace RudimentarySystem
{
   public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Grade GradeLevel { get; set; }
        public int NumOfQuestSelected { get; set; }
        public int Mode { get; set; }
        public Operation OperationSelection { get; set; }
        public int Current_Question { get; set; }
    }

    public enum Grade
    {
        Grade1,
        Grade2,
        Grade3,
        Grade12,
    }

    public enum Operation
    {
        Subtraction,
        Addition,
        Division,
        Multiplication
    }
}
