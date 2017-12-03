using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HandheldOrdering.ValueConverters
{
    
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string)
            {
                try
                {
                    return Color.FromHex(value?.ToString());
                }
                catch(Exception ex)
                {
                    return Color.Red;
                }
            }
            else
            {
                return Color.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Color)
            {
                return ((Color)value).ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
