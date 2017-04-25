using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFSampleApp
{
    class BetService : IBetService
    {
        public List<double> CalculateSin(double[] x)
        {
            return x.Select(p => Math.Sin(p)).ToList();
        }

        public string GetValue(int i)
        {
            return $"you have sent {i}";
        }
    }
}
