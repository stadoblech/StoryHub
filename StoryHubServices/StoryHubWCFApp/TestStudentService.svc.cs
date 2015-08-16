using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StoryHubWCFApp
{
    public class TestStudentService : ITestStudentService
    {
        public string ActivationTest()
        {
            return "gggg";
        }

        /*
public string GetData(int value)
{
   return string.Format("You entered: {0}", value);
}

public CompositeType GetDataUsingDataContract(CompositeType composite)
{
   if (composite == null)
   {
       throw new ArgumentNullException("composite");
   }
   if (composite.BoolValue)
   {
       composite.StringValue += "Suffix";
   }
   return composite;
}*/
        public Tuple<bool, string> AddStudent(Student student)
        {
            //vložení studenta do databáze
            return new Tuple<bool, string>(false, "Student already exists.");
        }

        public List<Student> GetAllStudents()
        {
            //vytáhnutí studentů z databáze
            return new List<Student>() { new Student() };
        }

        public Student GetStudent(string ID)
        {
            
            return queryForStudent();                 
        }

        private Student queryForStudent()
        {
            DatabaseConnector.Connect();
            SqlCommand cmd = DatabaseConnector.Connection.CreateCommand();
            cmd.CommandText = @"SELECT *
                                    FROM Student
                                    WHERE Student.ID = 1";
            SqlDataReader reader = cmd.ExecuteReader();
            Student student = new Student();
            while (reader.Read())
            {
                student.Id = Convert.ToInt32(reader["ID"]);
                student.Name = Convert.ToString(reader["name"]);
                student.Surename = Convert.ToString(reader["surename"]);
                //student.Iq = Convert.ToInt32(reader["IQ"]);
                //student.Birthdate = Convert.ToDateTime(reader["BirthDate"]);
                //int tallness = Convert.ToInt32(reader["tallness"]);
                //Console.WriteLine("{0} {1} {2}", login, lname, fname);//, tallness);

            }
            reader.Close();

            DatabaseConnector.Disconnect();
            return student;
        }
    }
}
