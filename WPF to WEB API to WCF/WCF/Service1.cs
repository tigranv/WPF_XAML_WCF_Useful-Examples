using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private List<Person> PersonsList;

        public Service1()
        {
            PersonsList = PersonDataClass.GenerateData();
        }
        


        //@h@n apres))))
        public List<Person> GetData()
        {
            return PersonsList;
        }

        public Person GetDataUsingDataContract(Person composite)
        {
            throw new NotImplementedException();
        }

        public string PostData(Person composite)
        {
            PersonsList.Add(composite);
            return $"{composite.Name}- added to list";
        }
    }
}
