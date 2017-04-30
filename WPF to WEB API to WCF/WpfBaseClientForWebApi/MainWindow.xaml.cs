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
using System.Collections.ObjectModel;

namespace WpfBaseClientForWebApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> personsList;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Get zaprosi button
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Sarqum enq list vori mej lcnelu enq wcf-ic ekac patasxan@, personneri lista
            //personsList = new ObservableCollection<Person>();

            //Stex sarqum enq httpclient u web.api-in get zapros enq anum 
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(@"http://localhost:55676/api/main").Result; // ushadir vor qo api-i hascen dnes stex
            //hima gna web.api u gti Get funkcian, heto kgas ksharunakes esi



            //response-ic kardum enq patasxan@, vor@ json formatov personneri lista
            string message = response.Content.ReadAsStringAsync().Result;
            //sarqum enq deserialaiser u patasxan@ darcnum enq ObservableCollection<Person>
            JavaScriptSerializer jss = new JavaScriptSerializer();
            personsList = jss.Deserialize<ObservableCollection<Person>>(message);

            foreach (var item in personsList)
            {
                Persons_List.Items.Add($"{item.ID} - {item.Name}");
            }            
        }

        private void CreateNew_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            Person p = new Person() { ID = int.Parse(textBoxID.Text), Name = textBoxName.Text, Age = int.Parse(textBoxAge.Text),};
            HttpResponseMessage response = client.PostAsync(@"http://localhost:55676/api/main", p, new JsonMediaTypeFormatter()).Result;
            string message = response.Content.ReadAsStringAsync().Result;
            JavaScriptSerializer jss = new JavaScriptSerializer();
            MessageBox.Show(jss.Deserialize<string>(message));
        }
    }


    //esi mer Mersonna uni 3 hat prop
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
