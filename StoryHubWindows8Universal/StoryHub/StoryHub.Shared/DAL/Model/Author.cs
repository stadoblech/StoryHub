using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Controls;

namespace StoryHub.DAL.Model
{
    public class Author
    {
        private string name = string.Empty;
        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        
        }

        private string surename = string.Empty;
        public string Surename
        {
            get { return surename; }
            set { surename = value; }
        }

        private string pseudonyme = string.Empty;
        public string Pseudonyme
        {
            get { return pseudonyme; }
            set { pseudonyme = value; }
        }

        private string description = string.Empty;
        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }

        private Image image = new Image();
        public Image Image
        {
            set
            {
                image = value;
            }
            get
            {
                return image;
            }
        }

        private List<string> stories = new List<string>();
        public List<string> Stories
        {
            set
            {
                stories = value;
            }
            get
            {
                return stories;
            }
        }

        private DateTime birthDate = new DateTime();
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private Nationality authorNationality = Nationality.None;
        public Nationality AuthorNationality
        {
            get { return authorNationality; }
            set { authorNationality = value; }
        }

        private Gender authorGender = Gender.None;
        public Gender AuthorGender
        {
            get { return authorGender; }
            set { authorGender = value; }
        }

        private List<Genre> authorGenres = new List<Genre>();
        public List<Genre> AuthorGenres
        {
            get { return authorGenres; }
            set { authorGenres = value; }
        }

        public override string ToString()
        {
            return pseudonyme;
        }






    }
}
