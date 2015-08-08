using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StoryHubWCFApp
{
    public class TestStudentService : ITestStudentService
    {
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
            //vytáhnutí studenta z databáze
            return null;                 
        }
    }
}
