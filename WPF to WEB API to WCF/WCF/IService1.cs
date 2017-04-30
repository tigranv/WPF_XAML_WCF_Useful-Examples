using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Person> GetData();

        [OperationContract]
        string PostData(Person composite);


        [OperationContract]
        Person GetDataUsingDataContract(Person composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCF.ContractType".
    [DataContract]
    public class Person
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
    }


    // es class@ poxarinuma mer datain, uxxaki ognakan classa vori mijocov personneri list
    public static class PersonDataClass
    {
        public static List<Person> GenerateData()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { ID = 1, Name = "Gayane", Age = 18 });
            list.Add(new Person() { ID = 2, Name = "Vanik", Age = 18 });
            list.Add(new Person() { ID = 3, Name = "Lusine", Age = 18 });
            list.Add(new Person() { ID = 4, Name = "Tsovinar", Age = 18 });
            list.Add(new Person() { ID = 4, Name = "Narek", Age = 18 });

            return list;
        }
    }
}
