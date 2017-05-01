using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF
{
    //stex service-na hmnakan funkcianerov
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Person> GetData();

        [OperationContract]
        string PostData(Person composite);
    }


    // sa mer Person classna vorin texapoxelu enq eskom en kom
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


    // es class@ poxarinuma mer datain, uxxaki ognakan classa vori mijocov personneri list enq stanum
    public static class PersonDataClass
    {
        public static List<Person> list = new List<Person>();

        static PersonDataClass()
        {
            list.Add(new Person() { ID = 1, Name = "Gayane", Age = 18 });
            list.Add(new Person() { ID = 2, Name = "Vanik", Age = 18 });
            list.Add(new Person() { ID = 3, Name = "Lusine", Age = 18 });
            list.Add(new Person() { ID = 4, Name = "Tsovinar", Age = 18 });
            list.Add(new Person() { ID = 5, Name = "Narek", Age = 18 });
        }
        
    }
}
