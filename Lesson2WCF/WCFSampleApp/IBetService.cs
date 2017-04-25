using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSampleApp
{
    [ServiceContract]
    public interface IBetService
    {
        [OperationContract]
        string GetValue(int i);

        [OperationContract]
        List<double> CalculateSin(double[] x);
    }
}
