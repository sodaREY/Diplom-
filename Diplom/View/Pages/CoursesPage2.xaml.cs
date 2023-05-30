using Diplom.View.WIndows;
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
    /// Логика взаимодействия для CoursesPage2.xaml
    /// </summary>
    public partial class CoursesPage2 : Page
    {
        
        public CoursesPage2()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            SkillBoxPage skillBoxPage = new SkillBoxPage(); 

            NavigationService.Navigate(skillBoxPage);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            NetologyPage netologyPage = new NetologyPage();

            NavigationService.Navigate(netologyPage);   
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            PrakticePage prakticePage = new PrakticePage();

            NavigationService.Navigate(prakticePage);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            SkillFacPage skillFacPage = new SkillFacPage();

            NavigationService.Navigate(skillFacPage);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            GeekPage geekPage = new GeekPage(); 

            NavigationService.Navigate(geekPage);

        }
    }
}
