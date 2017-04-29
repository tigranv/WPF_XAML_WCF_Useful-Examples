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
        //@h@n apres))))
        public string GetData(int value)
        {
            //de nayi wpf-d dimela es funkciayin che u uxarkela mi hat tiv(xosqi 5)
            //stex ed tvi het ari mi ban anenq u het uxarkenq, mi hat stringi mej drac tox inqnel ta ed strinq@ wpf-in!
            return string.Format("Dear Gayane take your number multiplied by 8:----> {0}", value*8);
        }

        public Person GetDataUsingDataContract(Person composite)
        {
            throw new NotImplementedException();
        }
    }
}
