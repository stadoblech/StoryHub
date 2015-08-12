using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryHubServicesSolution
{
    public abstract class FirstTestAbstractClass
    {
        public FirstTestAbstractClass()
        {
            name = "Jenda";
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
