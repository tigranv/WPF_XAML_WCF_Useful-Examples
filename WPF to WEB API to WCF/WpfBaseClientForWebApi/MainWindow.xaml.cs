using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows;
using System.Net.Http.Formatting;
using System.Collections.ObjectModel;

namespace WpfBaseClientForWebApi
{
    public partial class MainWindow : Window
    {
        //Sarqum enq list vori mej lcnelu enq wcf-ic ekac patasxan@, personneri lista
        private ObservableCollection<Person> personsList;
        public MainWindow()
        {
            InitializeComponent();
        }

        //Get zaprosi button
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Stex sarqum enq httpclient u web.api-in get zapros enq anum 
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(@"http://localhost:55676/api/main").Result; // sa saxis mot tarbera, ushadir!!!
            //hima gna web.api u gti Get funkcian, heto kgas ksharunakes esi

            //response-ic kardum enq patasxan@, vor@ json formatov personneri lista
            string message = response.Content.ReadAsStringAsync().Result;
            //sarqum enq deserialaiser u patasxan@ darcnum enq ObservableCollection<Person>
            JavaScriptSerializer jss = new JavaScriptSerializer();// ete sa chi ashxatum using enq anum System.Web.Script.Serialization
            //ete ed using@ chi &anachum referencnerum add enq anum aktivacnum enq System.Web.Extensions ptichken))))
            personsList = jss.Deserialize<ObservableCollection<Person>>(message);

            Persons_List.Items.Clear(); // exac@ maqrum enq vor amen angam tarmacvac data beri

            //stex stacvac personneri listic mez anhrajesht infon lcnum enq mer listboxi mej
            foreach (var item in personsList)
            {
                Persons_List.Items.Add($"{item.ID} - {item.Name}");
            }            
        }

        //Post zaprosi button
        private void CreateNew_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            //sarqum enq ed personin vor@ petqa poxancvi wcf-i
            Person p = new Person() { ID = int.Parse(textBoxID.Text), Name = textBoxName.Text, Age = int.Parse(textBoxAge.Text),};

            //post zaprosi het uxarkum enq iran api(apin el vekaluma uxarkuma wcf)
            HttpResponseMessage response = client.PostAsync(@"http://localhost:55676/api/main", p, new JsonMediaTypeFormatter()).Result;
            //ete JsonMediaTypeFormatter-@ chi ashxatum using enq anum using System.Net.Http.Formatting -@ (NUGET-um System.Net.Http.Formatting.Extension paketna)

            //api-ic stanum enq patasxan ardyoq sax lava gnacel te voch(irakanum apin stanuma patasxan@ wcf-ic u poxancuma mez eli)
            string message = response.Content.ReadAsStringAsync().Result;
            JavaScriptSerializer jss = new JavaScriptSerializer();

            //patasxan@ messageboxov cuyc enq talis
            MessageBox.Show(jss.Deserialize<string>(message));
        }


        //esia avelacel Gay
        private void UpdateNew_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            //sarqum enq ed personin vor@ petqa update lini, es mas@ lriv nuynna inch post zaprosi jamanak
            Person p = new Person() { ID = int.Parse(textBoxID.Text), Name = textBoxName.Text, Age = int.Parse(textBoxAge.Text), };

            //put zaprosi het uxarkum enq iran api(apin el vekaluma uxarkuma wcf)
            HttpResponseMessage response = client.PutAsync(@"http://localhost:55676/api/main", p, new JsonMediaTypeFormatter()).Result;

            //api-ic stanum enq patasxan ardyoq sax lava gnacel te voch
            string message = response.Content.ReadAsStringAsync().Result;
            JavaScriptSerializer jss = new JavaScriptSerializer();

            //patasxan@ messageboxov cuyc enq talis
            MessageBox.Show(jss.Deserialize<string>(message));
        }
    }


    //esi mer Personna uni 3 hat prop
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
