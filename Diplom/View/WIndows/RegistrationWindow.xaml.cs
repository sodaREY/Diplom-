using Diplom.AppData;
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
using System.Windows.Shapes;

namespace Diplom.View.WIndows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AuthLoginTbx_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AuthLoginTbx.Text == "Login")
            {
                AuthLoginTbx.Text = string.Empty;
            }
        }

        private void AuthLoginTbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthLoginTbx.Text))
            {
                AuthLoginTbx.Text = "Login";
            }
        }

        private void AuthPassPbx_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AuthPassPbx.Text == "Password")
            {
                AuthPassPbx.Text = string.Empty;
            }
        }

        private void AuthPassPbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthPassPbx.Text))
            {
                AuthPassPbx.Text = "Password";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }

        private void AuthLoginTbx_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if (AuthFIOTbx.Text == "FIO")
            {
                AuthFIOTbx.Text = string.Empty;
            }
        }

        private void AuthFIOTbx_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthFIOTbx.Text))
            {
                AuthFIOTbx.Text = "FIO";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //var v = AppData.ModelHelper.user23Entities.Client.Where(i => i.login == txb.Text && i.password == txb4.Password).FirstOrDefault();
            var v =Context.molochnikovKurs.Client.Where(i => i.login == AuthLoginTbx.Text && i.password == AuthPassPbx.Text).FirstOrDefault(); 
           
            //if (v != null)
            //{
            //    MessageBox.Show("Пользователь создан");
            //   StartWIndow startWIndow = new StartWIndow();
            //    startWIndow.Show();
            //    Close();

            //}
            string log = "";
            //if (string.IsNullOrWhiteSpace(txb.Text))
            //    log += "Введите логин\n";

            //if (string.IsNullOrWhiteSpace(txb4.Password))
            //    log += "Введите пароль\n";

            //if (string.IsNullOrWhiteSpace(txb5.Password))
            //    log += "Повторите пароль\n";


            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }
            Model.Client client = new Model.Client()
            {
                login = AuthLoginTbx.Text,
                password = AuthPassPbx.Text,
                FIO=AuthFIOTbx.Text
            };
            //ModelHelper.user23Entities.Client.Add(client);
            //ModelHelper.user23Entities.SaveChanges();
            //MessageBox.Show("Учетная запись создана");
            //txb.Text = "";

            Context.molochnikovKurs.Client.Add(client);
            Context.molochnikovKurs.SaveChanges();
            MessageBox.Show("Учетная запись создана");
            LoginWindow login = new LoginWindow();
            login.Show();
            Close();



        }
    }
}
