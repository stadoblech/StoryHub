using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.DAL.Parser
{
    interface Parser
    {
        void Push();
        void Pull();
    }
}
