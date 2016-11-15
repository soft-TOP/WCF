using System.ServiceModel;

namespace WcfHost
{
    [ServiceContract]
    public interface IWcfHost
    {
        [OperationContract]
        string Echo(string pString);

        [OperationContract]
        int Sum(int pNum1, int pNum2);
    }
}
