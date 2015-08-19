using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthorizationService" in both code and config file together.
[ServiceContract]
public interface IAuthorizationService
{
    [OperationContract]
    Tuple<string, bool> VerifyPassword(string email, string password);

    [OperationContract]
    Tuple<string, bool> VerifyEmail(string email);

    [OperationContract]
    Tuple<string, bool> Register(string email, string password, bool news, string appLanguage, bool useLiveTile, List<string> contentLanguages);

    [OperationContract]
    Tuple<string, bool> RemoveUser(string email);
}
