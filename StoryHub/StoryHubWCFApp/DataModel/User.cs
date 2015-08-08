using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.DAL.Model
{
    //v1
    public class User
    {
        private string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private List<Genre> favouriteGenres = new List<Genre>();
        public List<Genre> FavouriteGenres
        {
            get { return favouriteGenres; }
            set { favouriteGenres = value; }
        }

        private bool hasNewContent = false;
        public bool HasNewContent
        {
            get { return hasNewContent; }
            set { hasNewContent = value; }
        }

        private List<Storyline> storylines = new List<Storyline>();
        public List<Storyline> Storylines
        {
            get { return storylines; }
            set { storylines = value; }
        }

        private Author authorEgo = null;
        public Author AuthorEgo
        {
            get { return authorEgo; }
            set { authorEgo = value; }
        }

        private DateTime lastCheckTime = DateTime.Now;
        public DateTime LastCheckTime
        {
            get { return lastCheckTime; }
            set { lastCheckTime = value; }
        }

    }
}
