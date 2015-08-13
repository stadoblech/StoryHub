using StoryHub.DAL.Model;
using StoryHubWCFApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTestProject
{
    class Program
    {
        static void Main(string[] args)
        {


            



            Console.WriteLine(queryForUser("snek@gmail.com").Password);
        }

        private static User queryForUser(string ID)
        {
            DatabaseConnector.Connect();
            SqlCommand cmd = DatabaseConnector.Connection.CreateCommand();
            cmd.CommandText = @"SELECT *
                                    FROM Users
                                    WHERE Users.Email = @ID";
            cmd.Parameters.Add("@ID", SqlDbType.VarChar);
            cmd.Parameters["@ID"].Value = ID;
            SqlDataReader reader = cmd.ExecuteReader();
            User user = new User();
            while (reader.Read())
            {
                user.Email = Convert.ToString(reader["Email"]);
                user.Password = Convert.ToString(reader["Password"]);
                //student.Iq = Convert.ToInt32(reader["IQ"]);
                //student.Birthdate = Convert.ToDateTime(reader["BirthDate"]);
                //int tallness = Convert.ToInt32(reader["tallness"]);
                //Console.WriteLine("{0} {1} {2}", login, lname, fname);//, tallness);

            }
            reader.Close();

            DatabaseConnector.Disconnect();
            return user;
        }
    }

    
}
