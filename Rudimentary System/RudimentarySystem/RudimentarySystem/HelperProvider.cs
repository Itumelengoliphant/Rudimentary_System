using System;
using System.Collections.Generic;
using System.Text;

namespace RudimentarySystem
{
   public abstract class HelperProvider
    {
        public abstract bool NotEmptyNorNull(string input);

        public abstract bool IsNumberOnly();

        public abstract bool IsValidName(string name);

    }
}
