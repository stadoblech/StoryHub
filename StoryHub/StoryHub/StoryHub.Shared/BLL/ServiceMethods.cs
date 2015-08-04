using StoryHub.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.BLL
{
    class ServiceMethods
    {
        internal static List<string> GetGenres()
        {
            List<string> genres = new List<string>();
            var values = Enum.GetValues(typeof(Genre));
            foreach (var item in values)
            {
                genres.Add(item.ToString());
            }
            return genres;
        }
    }
}
