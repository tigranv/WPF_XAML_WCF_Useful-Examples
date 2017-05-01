using System.Collections.Generic;
using System.Web.Http;
using WebApiClinetForWCF.ServiceReference1;

namespace WebApiClinetForWCF.Controllers
{
    public class MainController : ApiController
    {
        //Nayi Gay jan esi proxyina(WCF-i clienti instance-@)
        Service1Client WCFclient = new Service1Client();

        // Hima mer Get@ arden veradardznuma collection personneri
        public IEnumerable<Person> Get()
        {
            //hima nayi wpf-ic get zapros@ ekela stex, menq hajord toxum en WCFclientov kpnum
            //enq WCF-in u kanchum enq ira GetData funkcian vor@ henc taluya personneri list
            IEnumerable<Person> result = WCFclient.GetData();
            // u poxancum enq ed collection@ wpf-in
            return result;
        }
      
        // Esi postna, sranov nor personin uxarkum enq wcf, u i patasxan asum stacvela te voch
        public IHttpActionResult Post([FromBody]Person value)
        {
            // stex valie-n wpf-ic ekac nor personna, iran vorpes parametr talis enw wxf-i postdata funkciayin
            // vor@ patasxaneluya stringov ete amen inch lav gna, ete che urem response-@ null klini
            string response = WCFclient.PostDataAsync(value).Result;

            //stex wpf-in asum enq sax lava te che
            if (response != null)
                return Ok(response);

            else
                return BadRequest();
        }      
    }
}
