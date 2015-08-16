using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StoryHub.DAL.Model;
using System.ServiceModel.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace StoryHubWCFApp
{
    [ServiceContract]
    public interface IGetSimpleDataService
    {
        [OperationContract]
        [WebGet(UriTemplate = "User/{ID}")]
        User GetUser(string ID);

        [OperationContract]
        [ScriptMethod(UseHttpGet = true)]
        User GetUserByMethod(string ID);

        [OperationContract]
        [WebGet]
        string ActivationTest();

        [OperationContract]
        [WebMethod]
        string WebMethodTest();

    }
}
