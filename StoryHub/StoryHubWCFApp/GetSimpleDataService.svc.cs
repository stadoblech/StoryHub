using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StoryHub.DAL.Model;
using System.Data.SqlClient;
using System.Data;

namespace StoryHubWCFApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetSimpleDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetSimpleDataService.svc or GetSimpleDataService.svc.cs at the Solution Explorer and start debugging.
    public class GetSimpleDataService : IGetSimpleDataService
    {
        public string ActivationTest()
        {
            return "Hello WOrld!!!";
        }

        public User GetUser(string ID)
        {
            return queryForUser(ID);
        }

        public User GetUserByMethod(string ID)
        {
            return queryForUser(ID);
        }

        private User queryForUser(string ID)
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
