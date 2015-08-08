using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryHubWCFApp
{
    public class Student
    {
        private int id = 0;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        private DateTime birthdate = DateTime.Today;
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }
        private int iq = 1;
        public int Iq
        {
            get
            {
                return iq;
            }

            set
            {
                iq = value;
            }
        }
        private string surename = string.Empty;
        public string Surename
        {
            get
            {
                return surename;
            }

            set
            {
                surename = value;
            }
        }
        private string name = string.Empty;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        
        
        
        
        
    }
}
