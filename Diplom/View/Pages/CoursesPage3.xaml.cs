using System.Data.SqlClient;
using System.Windows.Controls;

namespace Diplom.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CoursesPage3.xaml
    /// </summary>
    public partial class CoursesPage3 : Page
    {

       
        public CoursesPage3()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection("data source=DESKTOP-EDS6SSR;initial catalog=MolochnikovKurs;integrated security=True");
            connection.Open();

            string query = @"SELECT t.name AS TopicsName, th.name AS ThemesName, l.name AS LevelsName, c.name AS CoursesName
                    FROM Topics t
                    JOIN Themes th ON t.id = th.id
                    JOIN Levels l ON t.id = l.id
                    JOIN Courses c ON t.id = c.id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string topicName = reader.GetString(reader.GetOrdinal("TopicsName"));
                        string themeName = reader.GetString(reader.GetOrdinal("ThemesName"));
                        string levelName = reader.GetString(reader.GetOrdinal("LevelsName"));
                        string courseName = reader.GetString(reader.GetOrdinal("CoursesName"));

                        // здесь можно вывести полученные данные в соответствующие элементы управления
                        string listItem = $"{topicName} - {themeName} - {levelName} - {courseName}";

                        // добавить элемент в список
                        listBox.Items.Add(listItem);
                    }
                }
            }

            //string levelName = (string)cmb.SelectionBoxItemStringFormat; // выбранное название уровня
            //int levelId;

            //// запрос на выборку id уровня с заданным именем
            //SqlCommand command = new SqlCommand("SELECT id FROM Levels WHERE name='" + levelName + "'", connection);
            //SqlDataReader reader = command.ExecuteReader();
            //if (reader.Read())
            //{
            //    levelId = reader.GetInt32(0);

            //    // запрос на изменение атрибута courses у клиента с заданным идентификатором
            //    command = new SqlCommand("UPDATE Clients SET courses=" + levelId + " WHERE id=" + 7, connection);
            //    command.ExecuteNonQuery();

            //}
        }
    }
}
