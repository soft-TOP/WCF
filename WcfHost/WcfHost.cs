using System;
using System.ServiceModel;

namespace WcfHost
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class WcfHost : IWcfHost
    {
        public string Echo(string pString)
        {
            return String.Format("You've entered: {0}", pString);
        }

        public int Sum(int pNum1, int pNum2)
        {
            return pNum1 + pNum2;
        }
    }
}