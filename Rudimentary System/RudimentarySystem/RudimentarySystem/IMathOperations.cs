using System;
using System.Collections.Generic;
using System.Text;

namespace RudimentarySystem
{
   public interface IMathOperations<T>
    {
        T Subtraction(T num1, T num2);

        T Division(T num1, T num2);

        T Multiplication(T num1, T num2);

        T Average(T num1, T num2);
    }
}
 