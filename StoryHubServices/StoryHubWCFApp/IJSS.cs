using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StoryHubWCFApp
{

    [ServiceContract]    
    public interface IJSS
    {
        [OperationContract]
        [WebGet(UriTemplate = "User/{ID}")]
        User
    }
}
