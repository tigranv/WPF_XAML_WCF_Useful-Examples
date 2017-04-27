using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    public class ServiceSender : ISender
    {
        

        
        public string GetData(int value)
        {
            Uri address = new Uri("http://localhost:4000/ISender");
            BasicHttpBinding binding = new BasicHttpBinding();

            ChannelFactory<ISender> factory = new ChannelFactory<ISender>(binding, new EndpointAddress(address));
            ISender channel = factory.CreateChannel();
        
            string a = channel.GetData(25);
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
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
