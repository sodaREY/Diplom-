using Diplom.AppData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            cmb.SelectedValuePath = "id";
            cmb.DisplayMemberPath = "name";
            cmb.ItemsSource = Context.molochnikovKurs.Levels.ToList();
            //ComboBox cmb = new ComboBox();

            //cmb.Items.AddRange(new string[] { "начальный 1", "средний 2", "высок 3", "" });
            //string selectedLevelName;
            //cmb.SelectedIndexChanged += (s, e) =>
            //{
            //    cmb.SelectedItem = cmb.SelectedItem.ToString();
            //};
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection("data source=SQL;initial catalog=MolochnikovKurs;integrated security=True");
            connection.Open();

            string levelName = (string)cmb.SelectionBoxItemStringFormat; // выбранное название уровня
            int levelId;

            // запрос на выборку id уровня с заданным именем
            SqlCommand command = new SqlCommand("SELECT id FROM Levels WHERE name='" + levelName + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                levelId = reader.GetInt32(0);

                // запрос на изменение атрибута courses у клиента с заданным идентификатором
                command = new SqlCommand("UPDATE Clients SET courses=" + levelId + " WHERE id=" + 5, connection);
                command.ExecuteNonQuery();

            }
            Model.Levels levels = new Model.Levels()
            {
                name = cmb.SelectionBoxItemStringFormat 
        };
            //ModelHelper.user23Entities.Client.Add(client);
            Context.molochnikovKurs.SaveChanges();
            //MessageBox.Show("Учетная запись создана");
            //txb.Text = "";


            Context.molochnikovKurs.SaveChanges();

            connection.Close();
            MessageBox.Show("уровень выбран");
        }
    }
}
