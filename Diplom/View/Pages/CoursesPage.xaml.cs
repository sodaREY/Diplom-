using Diplom.AppData;
using Diplom.Model;
using System;
using System.Collections.Generic;
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

namespace Diplom.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CoursesPage.xaml
    /// </summary>
    public partial class CoursesPage : Page
    {
        public CoursesPage()
        {
            InitializeComponent();
            Flowerlist.ItemsSource=Context.molochnikovKurs.Client.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
           

            if(Flowerlist.SelectedItem != null)
            {
                int num1 = Convert.ToInt32(ItemAmountTb1.Text);
                Client client = (Client)Flowerlist.SelectedItem;
                client.FIO = ItemIdTb.Text;
                client.login = ItemNameTb.Text;
                client.password = ItemAmountTb.Text;
                client.levels = num1;
                Context.molochnikovKurs.SaveChanges();
                Flowerlist.ItemsSource = Context.molochnikovKurs.Client.ToList();
            }
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(ItemAmountTb1.Text);
            Client client = new Client();
            client.FIO=ItemIdTb.Text;
            client.login=ItemNameTb.Text;
            client.password=ItemAmountTb.Text;
            client.levels = num1;
            Context.molochnikovKurs.Client.Add(client);
            Context.molochnikovKurs.SaveChanges();
            Flowerlist.ItemsSource= Context.molochnikovKurs.Client.ToList();    
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
           
            if (Flowerlist.SelectedItem != null)
            {
                Client client = (Client)Flowerlist.SelectedItem;
                Context.molochnikovKurs.Client.Remove(client);
                Context.molochnikovKurs.SaveChanges();
                Flowerlist.ItemsSource = Context.molochnikovKurs.Client.ToList();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
