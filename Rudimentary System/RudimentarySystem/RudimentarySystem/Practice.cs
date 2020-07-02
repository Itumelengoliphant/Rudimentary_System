using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RudimentarySystem
{
    public class Practice : OperationsProviderBase,IDetails
    {
        public void OnPracticeModeSelection()
        {

        }

        public override void OnAdditionSelection()
        {
            throw new NotImplementedException();
        }

        public override void OnDivisionSelection()
        {
            throw new NotImplementedException();
        }

        public override void OnMultiplicationSelection()
        {
            throw new NotImplementedException();
        }

        public override void OnSubtractionSelection()
        {
            throw new NotImplementedException();
        }

        public void OnDetailsCaptured(Student student)
        {
            WriteLine($"\nConfirm your details below:\nName: {student.Name}\nSurname: {student.Surname}\n" +
                      $"Mode: {student.Mode}\nNumber of Questions: {student.NumOfQuestSelected}\nGrade: " +
                      $"{student.GradeLevel}\nOperation: {student.OperationSelection}");
        }
    }
}
