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
    class SpectrumValueToBackgroudConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (int.Parse(value.ToString()) < 83)
                {
                    return new SolidColorBrush
                    {
                        Color = Color.FromRgb(0, 204, 0)
                        
                    };
                }
                else if (int.Parse(value.ToString()) < 166)
                {
                    return new SolidColorBrush
                    {
                        Color = Color.FromRgb(255, 204, 0)                        
                    };
                }
                else return new SolidColorBrush
                {
                    Color = Color.FromRgb(204, 0, 0)
                };
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
