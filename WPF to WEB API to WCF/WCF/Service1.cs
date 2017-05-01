using System.Collections.Generic;

namespace WCF
{
    public class Service1 : IService1
    {
        
        //@h@n apres)))), stex amen inch shat parza
        public IEnumerable<Person> GetData()
        {
            //sa sovorakan get zaprosna, vercnuma en datai list@ shprtuma api-in, eni el poxancuma wpf-in
            return PersonDataClass.list;
        }


        public string PostData(Person composite)
        {
            // esi postna, vercnuma ekac personin(stex anun@ composite-a) u avelacnuma en ognakan static class-i listi mej
            PersonDataClass.list.Add(composite);

            // ete 19-rd tox@ normal katarvuma, veradardzuma string vor sax lava avelacrel em
            return $"{composite.Name}- added to list";
        }
    }
}
