using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http.Formatting;


namespace WpfBaseClientForWebApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Stex sarqum enq httpclient u web.api-in get zapros enq anum 
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(@"http://localhost:55676/api/main").Result; // ushadir vor qo api-i hascen dnes stex
            //hima gna web.api u gti Get funkcian, heto kgas ksharunakes esi



            //response-ic kardum enq patasxan@, vor@ json formatova
            string message = response.Content.ReadAsStringAsync().Result;
            //sarqum enq deserialaiser u patasxan@ darcnum enq string
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string content = jss.Deserialize<string>(message);
            //ed string@ qcum enq textboxi mej
            textbox1.Text = content;




            //esi eli post zaprosi hamara hima petq chi nayel
            //Person p = new Person() { Name = "Satenik", Age = 20 };
            //HttpResponseMessage response = client.PostAsync(@"http://localhost:55676/api/main", p, new JsonMediaTypeFormatter()).Result;
            //string message = response.Content.ReadAsStringAsync().Result;
            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //string content = jss.Deserialize<string>(message);
        }
    }

    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
}
