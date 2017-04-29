﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.ServiceReference1;
using WpfApplication1.ServiceReference2;

namespace WpfApplication1
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new BetServiceClient();

            var person = await proxy.GetPersonAsync();


            foreach (var item in person)
            {
                Debug.WriteLine($"{item.Name}, {item.Age}");
            }
        }

        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            var proxy2 = new Service2Client();

            var game = await proxy2.GetDataUsingDataContractAsync(new Game()
            {
                BoolValue = true,
                StringValue = "Jhon"     
            });

            MessageBox.Show($"{game.StringValue}, {game.BoolValue}");
        }
    }
}