using System;
using System.Collections.Generic;
using System.Text;
using Windows.Data.Xml.Dom;
using Windows.UI.Xaml.Controls;

namespace StoryHub.DAL.Model
{
    public class Story
    {
        private string title = string.Empty;                              //vytvoření proměnných

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string subtitle = string.Empty;

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }
        private Author author = new Author();

        internal Author Author
        {
            get { return author; }
            set { author = value; }
        }
        private bool isNew = true;

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        private Image image = new Image();

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        private int rating = 0;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        private DateTime added = new DateTime();

        public DateTime Added
        {
            get { return added; }
            set { added = value; }
        }
        private string body = string.Empty;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }
    }
}
