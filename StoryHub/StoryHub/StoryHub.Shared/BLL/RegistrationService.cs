using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.BLL
{
    //v2
    public static class RegistrationService
    {
        

        public static Tuple<bool, string> Register(string email, string password, bool newsletter)
        { 
            //stub - vloží na server email, heslo a zda chce dostávat newsletter
            //server je nedosažitelný
            return new Tuple<bool, string>(false, "Server is unreachable.");
            //email již existuje
            return new Tuple<bool, string>(false, "This is email already is registered.");
            //registrováno
            return new Tuple<bool, string>(true, "You are registered. Check for activation email.");
        }
    }
}
