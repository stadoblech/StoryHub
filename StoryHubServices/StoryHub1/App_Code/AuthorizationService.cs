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
        AuthorizationLinqDataContext database = new AuthorizationLinqDataContext();
        User user = new User() {
            Email = email,
            Password = password,
            WantsNews = news,
            AppLanguage = appLanguage,
            UseLiveTile = useLiveTile,
            Activated = true,
            HasNewContent = true,
            UiDesign = "default"                        
        };
        foreach (var language in contentLanguages)
        {
            user.StoriesLanguages += language;
        }

        database.Users.InsertOnSubmit(user);

        try
        {
            database.SubmitChanges();
            return new Tuple<string, bool>("You are registered now. Welcome to StoryHub", true);
        }
        catch (Exception e)
        {
            return new Tuple<string, bool>("Sorry, we cannot register you right now. Try it later." + e, false);
            throw e;
            
        }
    }

    public Tuple<string, bool> RemoveUser(string email)
    {
        AuthorizationLinqDataContext database = new AuthorizationLinqDataContext();
        var result = from u in database.Users
                     where u.Email == email
                     select u;

        database.Users.DeleteAllOnSubmit(result);

        try
        {
            database.SubmitChanges();
            return new Tuple<string, bool>("User" + email + " is deleted now.", true);
        }
        catch (Exception)
        {
            return new Tuple<string, bool>("User is not deleted, try it later.", false);
        }
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

    /// <summary>
    /// Method for login authentication. This method needs email and password and returns status.
    /// If email is not correct, method returns string and false.
    /// If password is not correct, method returns string and false.
    /// If both email and password is correct, method returns approval string and true.
    /// </summary>
    /// <param name="email">E-mail/login</param>
    /// <param name="password">Password</param>
    /// <returns></returns>
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
