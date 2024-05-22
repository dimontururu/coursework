using System.Drawing;

namespace Игра_пазлы
{
    internal class BitmapResizer
    {
        private BitmapResizer() { }

        /// <summary>
        /// растягиевает изаброжение на весь bitmap
        /// </summary>
        /// <param name="stretch"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <returns></returns>
        public static Bitmap Resize(Image stretch,int Width, int Height)
        {

            Bitmap stretchedImage = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(stretchedImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(stretch, 0, 0, stretchedImage.Width, stretchedImage.Height);
            g.Dispose();

            return stretchedImage;
        }
    }
}
