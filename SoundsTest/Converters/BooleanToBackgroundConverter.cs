using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SoundsTest.Converters
{
    class BooleanToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool valueType = (bool)value;

            if (valueType == true)
            {
                return new SolidColorBrush
                {
                    Color = Color.FromRgb(255, 109, 0)
                };
            }
            else
                return new SolidColorBrush
                {
                    Color = Color.FromRgb(240, 240, 240)
                };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
