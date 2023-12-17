using System.Collections.Generic;
using School.Models;
using MySql.Data.MySqlClient;

namespace School.db
{
    public class SubjectDB : SubjectModel
    {
        public SubjectDB(
            int id,
            string subjectName,
            int price
        ) : base(id, subjectName, price)
        {

        }

        public static List<SubjectModel> GetAll()
        {
            List<SubjectModel> subjects = new List<SubjectModel>();
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM `Servises`";
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        subjects.Add(new SubjectDB(
                           id: reader.GetInt32(0),
                           subjectName: reader.GetString(1),
                           price: reader.GetInt32(2)
                        ));
                    }
                }
            }

            return subjects;
        }
    }
}
