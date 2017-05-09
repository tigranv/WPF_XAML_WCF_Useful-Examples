using System;

namespace Wcf2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service2 : IService2
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Game GetDataUsingDataContract(Game composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
