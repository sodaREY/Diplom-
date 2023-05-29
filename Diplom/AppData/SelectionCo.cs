using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.AppData
{
     class SelectionCo
    {
       

            // подключение к базе данных
           //SqlConnection connection = new SqlConnection(@"data source = DESKTOP - EDS6SSR; initial catalog = MolochnikovKurs; integrated security = True");

         
        //        {
        //            connection.Open();

        //            // запрос на выборку курсов с заданной сложностью
        //            string query = "SELECT Id, Title, Description, Difficulty FROM Courses WHERE Difficulty = @difficulty";
        //SqlCommand command = new SqlCommand(query, connection);
        //command.Parameters.AddWithValue("@difficulty", difficulty);

        //            // выполнение запроса и чтение данных
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Course course = new Course();
        //course.Id = reader.GetInt32(0);
        //                    course.Title = reader.GetString(1);
        //                    course.Description = reader.GetString(2);
        //                    course.Difficulty = reader.GetInt32(3);

        //                    courses.Add(course);
        //                }
        //            }
        //        }

        //        return courses;
    }
}
