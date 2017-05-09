using System.Collections.Generic;
using System.ServiceModel;

namespace WCFSampleApp
{
    [ServiceContract]
    public interface IBetService
    {
        [OperationContract]
        string GetValue(int i);

        [OperationContract]
        List<double> CalculateSin(double[] x);

        [OperationContract]
        List<Person> GetPerson();

    }
}
