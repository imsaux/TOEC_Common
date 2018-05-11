using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;

namespace TOEC_Common
{
    /// <summary>
    /// Add By: 朱恒
    /// 2016-03-28 
    /// Refrence Bootstrap Color Plan
    /// </summary>
    public static class MediaCommonColor
    {
        public static Color White
        {
            get { return Color.FromRgb(255, 255, 255); }
        }
        public static Color Default
        {
            get { return Color.FromRgb(255, 255, 255); }
        }
        public static Color Primary
        {
            get { return Color.FromRgb(51, 122, 183); }
        }
        public static Color Warning
        {
            get { return Color.FromRgb(240, 173, 78); }
        }
        public static Color Danger
        {
            get { return Color.FromRgb(217, 83, 79); }
        }
        public static Color Info
        {
            get { return Color.FromRgb(91, 192, 222); }
        }
        public static Color Success
        {
            get { return Color.FromRgb(68, 157, 68); }
        }
        public static Color Gainsboro
        {
            get { return Color.FromRgb(220, 220, 220); }
        }
        public static Color LightDark
        {
            get { return Color.FromRgb(51, 51, 55); }
            //get { return Color.FromRgb(104, 104, 104); }
        }
        public static Color Dark
        {
            get { return Color.FromRgb(30, 30, 30); }
        }
        public static Color DarkGold
        {
            get { return Color.FromRgb(215, 171, 105); }
        }
    }
}
