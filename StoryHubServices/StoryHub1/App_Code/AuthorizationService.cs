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

    /// <summary>
    /// Method for e-mail verification. Will return tuple with result string and result bool value.
    /// If e-mail is in the database, method will return true.
    /// If e-mail is not in the database, method will return false. 
    /// </summary>
    /// <param name="email">Virtualy both user's login name and contact e-mail address.</param>
    /// <returns></returns>
    public Tuple<string, bool> VerifyEmail(string email)
    {
        AuthorizationLinqDataContext database = new AuthorizationLinqDataContext();
        var result = from u in database.Users
                     where u.Email == email
                     select u;

        if (result.Count() > 0)
            return new Tuple<string, bool>("Email is in the database.", true);          
        else
            return new Tuple<string, bool>("Email is not in the database.", false);     
    }

    public Tuple<string, bool> VerifyPassword(string email, string password)
    {
        AuthorizationLinqDataContext database = new AuthorizationLinqDataContext();
        var result = from u in database.Users
                     where u.Email == email
                     select u;

        if (result.Count() == 0)
            return new Tuple<string, bool>("This e-mail is not in the database.", false);
        if (result.First().Password == password)
            return new Tuple<string, bool>("Welcome back", true);
        else
            return new Tuple<string, bool>("This password is not correct.", false);
    }
}
