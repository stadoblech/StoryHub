using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace StoryHub.DAL
{
    public class GenresToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            StringBuilder returnstring = new StringBuilder();
            foreach (var item in value as List<StoryHub.DAL.Model.Genre>)
            {
                returnstring.Append(item.ToString());
            }
            return returnstring;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class RestrictionsToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            StringBuilder returnstring = new StringBuilder();
            foreach (var item in value as List<StoryHub.DAL.Model.Restriction>)
            {
                returnstring.Append(item.Name);
            }
            return returnstring;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
