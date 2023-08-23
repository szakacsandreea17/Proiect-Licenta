using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace SzakacsAndreea_2023_Licenta.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (targetType == typeof(BitmapImage))
            {
                if (value != null && value is byte[])
                {
                    byte[] byteArray = (byte[])value;

                    using (MemoryStream ms = new MemoryStream(byteArray))
                    {
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();

                        //CacheOption trebuie setat dupa BeginInit()
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;

                        bitmapImage.StreamSource = ms;
                        bitmapImage.EndInit();
                        if (bitmapImage.CanFreeze) bitmapImage.Freeze();

                        return bitmapImage;
                    }
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (targetType == typeof(byte[]))
            {
                if (value != null && value is BitmapImage)
                {
                    BitmapImage bitmapImage = (BitmapImage)value;
                    byte[] byteArray = null;

                    var encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    using (MemoryStream ms = new MemoryStream())
                    {
                        encoder.Save(ms);
                        byteArray = ms.ToArray();
                    }

                    return byteArray;
                }
            }
            return value;
        }
    }
}
