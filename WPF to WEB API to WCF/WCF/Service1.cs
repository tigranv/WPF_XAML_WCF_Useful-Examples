using System;
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

        public string UpdateData(Person composite)
        {
            // es flag@ dnum enq vor tenanq gtela tenc person te voch
            bool flag = false;
            // hima nayi mer en listi vrov foreachov frum enq, u meji ifov man enq galis edID-ov mardun, henc gtnum enq ira nun u tariq@ poxum enq
            
            foreach (var item in PersonDataClass.list)
            {
                if (item.ID == composite.ID)
                {
                    item.Name = composite.Name;
                    item.Age = composite.Age;
                    flag = true;
                    break;
                }
            }

            // stex stugum enq ete flag@ trua darel, urem asum enq okasax poxel em, isk ete che asum enq tenc ID-ov mard chka
            return flag ? $"Person with Id = {composite.ID}- Updated":$"No person with {composite.ID}";
        }
    }
}
