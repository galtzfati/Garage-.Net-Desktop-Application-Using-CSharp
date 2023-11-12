using System.Drawing;

namespace GarageDesktopApplication.Extensions
{
    public static class ColorExtensions
    {
        public static bool IsDarkColor(this Color color)
        {
            double luminance = (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
            return luminance < 0.5;
        }
    }
}
