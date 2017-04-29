using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiClinetForWCF.ServiceReference1;

namespace WebApiClinetForWCF.Controllers
{
    public class MainController : ApiController
    {
        //Nayi Gay jan esi proxyina(WCF-i clienti instance-@)
        Service1Client WCFclient = new Service1Client();


        // esi sovorakan aranc parametri get funkciaya
        public string Get()
        {
            //hima nayi wpf-ic get zapros@ ekela stex, menq hajord toxum en WCFclientov kpnum
            //enq WCF-in u kanchum enq ira GetData funkcian inq@ stanuma mi hat tiv(entadrenq ed tiv@ ekel er WPF-ic)
            //u veradardznuma inch vor string, vor@ vorpes result mer stexi get funkcian heta talis WPF-in(hima gna WCF GetData funkcian gti asem)
            string result = WCFclient.GetData(5);

            
    
            return result;

            //irakanum petqa senc kanches vor lini asinxron, esi nuyn 20-rd toxi kanchna bayc ed funkcian sarqvuma takis, u karas ogtagorces eli.
            //string result = WCFclient.GetDataAsync(5).Result;
        }

       
        // Esi postna sranov arden data enq uxarkum wcf-in u stanum sra masin myus angam kxosanq
        public void Post([FromBody]Person value)
        {
            WCFclient.GetDataUsingDataContractAsync(value);
        }

      
    }
}
