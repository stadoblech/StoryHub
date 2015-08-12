using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryHubServicesSolution
{
    public abstract class SecondTestAbstractClass : FirstTestAbstractClass
    {
        public SecondTestAbstractClass()
        {
            surename = "Smolík";
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
    }
}
