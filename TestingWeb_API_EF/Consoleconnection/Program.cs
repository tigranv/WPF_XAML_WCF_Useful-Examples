using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BetC_CRM_DatabaseEntities db = new BetC_CRM_DatabaseEntities())
            {
                //IEnumerable<EmailList> phone = db.EmailLists.ToList();
                //phone = phone.Where(p => p.EmailListID > 0);

                //Console.WriteLine(phone.ToString());
                //Console.ReadKey();

                //foreach (var item in phone)
                //{
                //    Console.WriteLine("{0}.{1}", item.EmailListID, item.EmailListName);
                //}

                //Console.WriteLine("---------------------------------");
                //Console.ReadKey();

                IQueryable<EmailList> list1 = db.EmailLists;
                //Console.ReadKey();


                list1 = list1.Where(p => p.EmailListID == 1);
                Console.ReadKey();

                Console.WriteLine(list1);
                //Console.ReadKey();

                foreach (var item in list1)
                {
                    Console.WriteLine("{0}.{1}", item.EmailListID, item.EmailListName);
                }
            }






            Console.ReadKey();
        }
    }
}
