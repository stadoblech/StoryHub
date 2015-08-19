using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthorizationService" in code, svc and config file together.
public class AuthorizationService : IAuthorizationService
{
    public Tuple<string, bool> Register(string email, string password, bool news, string appLanguage, bool useLiveTile, List<string> contentLanguages)
    {
        throw new NotImplementedException();
    }

    public Tuple<string, bool> RemoveUser(string email)
    {
        throw new NotImplementedException();
    }

    public Tuple<string, bool> VerifyEmail(string email)
    {
        var a = new AuthorizationLinqDataContext();
        var b = new User();
        if (b.Email == email)
            return new Tuple<string, bool>("Email is in the database.", true);          //email is in the database
        else
            return new Tuple<string, bool>("Email is not in the database.", false);     //email is not in the database
    }

    public Tuple<string, bool> VerifyPassword(string email, string password)
    {
        throw new NotImplementedException();
    }
}
