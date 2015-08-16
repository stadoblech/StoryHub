using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace StoryHub.DAL
{
    class VisibilityConvertor : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch ((bool)value)
            {
                case true:
                    return Visibility.Visible;
                    break;
                case false:
                    return Visibility.Collapsed;
                    break;
                default:
                    return Visibility.Collapsed;
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
