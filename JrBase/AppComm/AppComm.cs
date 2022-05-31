using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace JrBase.AppComm
{
    public class LeftPanelDimensionsConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double? dTotalWidth = 0;

            foreach (object o in values)
            {
                bool bParsed = int.TryParse(o.ToString(), out int nCurrent);
                if (bParsed)
                {
                    dTotalWidth += nCurrent;
                }
            }

            //ensure negative dValue for scolling Right
            return dTotalWidth;
        }

        public object[] ConvertBack(object dValue, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// SideBar Margin 조절
    /// </summary>
    internal class LeftPanelMarginConverter : IValueConverter
    {
        public object Convert(object dValue, Type targetType, object parameter, CultureInfo culture)
        {
            if (dValue is double)
            {
                double dWidth = (double)dValue;
                Thickness panelMarginThickness = new Thickness(0, 0, dWidth * -1, 0);
                return panelMarginThickness;
            }

            throw new NotImplementedException();
        }

        public object ConvertBack(object dValue, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// SideBar 슬라이딩 조절
    /// </summary>
    internal class RightPanelDimensionsConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double? dTotalWidth = 0;

            //Combine all the values passed to give a total dWidth
            foreach (object o in values)
            {
                bool bParsed = int.TryParse(o.ToString(), out int nCurrent);
                if (bParsed)
                {
                    dTotalWidth += nCurrent;
                }
            }

            //ensure negative dValue for scolling left
            dTotalWidth *= -1;
            return dTotalWidth;
        }

        public object[] ConvertBack(object dValue, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// SideBar Margin 조절
    /// </summary>
    internal class RightPanelMarginConverter : IValueConverter
    {
        public object Convert(object dValue, Type targetType, object parameter, CultureInfo culture)
        {
            if (dValue is double)
            {
                double dWidth = (double)dValue;
                Thickness panelMarginThickness = new Thickness(dWidth * -1, 0, 0, 0);
                return panelMarginThickness;
            }

            throw new NotImplementedException();
        }

        public object ConvertBack(object dValue, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
