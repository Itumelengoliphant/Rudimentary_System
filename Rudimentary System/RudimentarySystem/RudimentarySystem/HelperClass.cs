using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RudimentarySystem
{
    public class HelperClass : HelperProvider
    {
        public override bool IsNumberOnly()
        {
            throw new NotImplementedException();
        }

        public override bool IsValidName(string name)
        {
            throw new NotImplementedException();
        }

        public override bool NotEmptyNorNull(string input)
        {
            bool isOK = false;

            if (!(string.IsNullOrEmpty(input)))
            {
                isOK = true;
            }

            return isOK;
        }

        public void DisplayMessage(string message)
        {
            if (NotEmptyNorNull(message))
            {
                Console.WriteLine(message);
            }
        }

        public string GetMessage(string input)
        {
            return input;
        }
    }
}
