using System;
using System.Collections.Generic;
using System.Text;

namespace RudimentarySystem
{
   public abstract class OperationsProviderBase
    {
        public abstract void OnAdditionSelection();

        public abstract void OnSubtractionSelection();

        public abstract void OnDivisionSelection();

        public abstract void OnMultiplicationSelection();
    }
}
