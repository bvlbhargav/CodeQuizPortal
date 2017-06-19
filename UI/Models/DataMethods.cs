using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class DataMethods
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ToString();
        public List<CodeQuiz> GetCodeQuizzes()
        {
            var codeQuizzes = new List<CodeQuiz>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("CQ_GetAllCodeQuizzes", connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        codeQuizzes.Add(new CodeQuiz() {
                            Title = reader["title"].ToString(),
                            Description = reader["description"].ToString(),
                            StartTime = DateTime.Parse( reader["starttime"].ToString()),
                            EndTime = DateTime.Parse(reader["endtime"].ToString())
                        });
                    }
                }
            }

            return codeQuizzes;
        }

    }
}