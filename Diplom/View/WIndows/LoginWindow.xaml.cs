using Diplom.AppData;
using Diplom.Model;
using MaterialDesignThemes.Wpf;
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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public static Client curUser { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
        }

        //public void ShowInfoMessage(string message)
        //{
        //    // вызываем MaterialMessageBox с кнопкой ОК
        //    var messageBox = new MaterialMessageBox
        //    {
        //        MessageFontSize = 18,
        //        Message = message,
        //        OkButtonMessage = "OK"
        //    };
        //    messageBox.ShowDialog();

        //    // для закрытия с помощью кнопки ОК используем событие Closed
        //    messageBox.Closed += (s, e) => messageBox = null;
        //}

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
            
            var user = Context.molochnikovKurs.Client.Where(p => p.login == AuthLoginTbx.Text && p.password == AuthPassPbx.Text).FirstOrDefault();
            if (user != null)
            {
                curUser = user;
                StartWIndow mainWindow = new StartWIndow();
                mainWindow.Show();

                MessageBox.Show("Добро пожаловать");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
            //string log = "";
            //if (string.IsNullOrWhiteSpace(AuthLoginTbx.Text))
            //    log += "Введите логин\n";

            //if (string.IsNullOrWhiteSpace(AuthPassPbx.Text))
            //    log += "Введите пароль\n";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            Close();
        }
    }
}
