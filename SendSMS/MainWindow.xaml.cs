using Newtonsoft.Json;
using SendSMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace SendSMS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtPhone.Focus();
        }

        //public void GetMessage()
        //{
        //    using (WebClient client = new WebClient())
        //    {

        //    }
        //}

        public void PostMessage()
        {
            using (WebClient client = new WebClient())
            {
                string url = "https://localhost:44352/api/LogSend";
                client.Encoding = Encoding.UTF8;
                client.Headers.Add("Content-Type", "application/json");
                string data = JsonConvert.SerializeObject(new
                {
                    Recipient = txtPhone.Text,
                    Message = txtMessage.Text,
                    ApiKey = txtKey.Text
                });
                var result = client.UploadString(url, "POST", data);
            }
        }

        private void BtnGet_Click(object sender, RoutedEventArgs e)
        {
            PostMessage();
            this.Close();
        }

        private void GotFocus_Phone(object sender, RoutedEventArgs e)
        {
            txtPhone.SelectAll();
        }

        private void GotFocus_Mes(object sender, RoutedEventArgs e)
        {
            txtMessage.SelectAll();
        }

        private void GotFocus_Key(object sender, RoutedEventArgs e)
        {
            txtKey.SelectAll();
        }
    }
}
