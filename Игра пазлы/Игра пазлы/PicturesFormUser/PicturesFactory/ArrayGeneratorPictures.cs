using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Игра_пазлы.PicturesFormUser.PicturesFactory
{
    internal class ArrayGeneratorPictures:IArrayPicturesFactory
    {
        public PicturesOnTheMainScreen[] Create(Control FormOrPanel, EventHandler pictureBoxClick = null)
        {
            Image[] arrayImage =  GetAnArrayOfImages.GetArray(@"C:\Users\Дима\Desktop\картинки");
            
            string[] arrayNameImage = GetAnArrayOfNameImage.GetArray(@"C:\Users\Дима\Desktop\картинки");
            PicturesOnTheMainScreen[] arrayPictures = new PicturesOnTheMainScreen[arrayImage.Length];

            const int pictureBoxWidth = 288;
            const int pictureBoxHeight = 162;
            const int pictureBoxMargin = 10;
            for(int i = 0; i < arrayImage.Length; i++)
            {
                arrayImage[i] = FixedSize(arrayImage[i], pictureBoxWidth, pictureBoxHeight, true);
            }
            int pictureBoxXStart = (FormOrPanel.Width - FormOrPanel.Width / (pictureBoxWidth + pictureBoxMargin) * (pictureBoxWidth + pictureBoxMargin)) / 2;

            int x = pictureBoxXStart;
            int y = pictureBoxMargin;

            for (int i = 0; i < arrayPictures.Length; i++)
            {
                arrayPictures[i] = new PicturesOnTheMainScreen(new Point(x, y), new Size(pictureBoxWidth, pictureBoxHeight), arrayNameImage[i], arrayImage[i],pictureBoxClick);

                x += pictureBoxWidth + pictureBoxMargin;
                if (x + pictureBoxWidth >= FormOrPanel.Width)
                {
                    x = pictureBoxXStart;
                    y += pictureBoxHeight + pictureBoxMargin + 50;
                }
            }
            return arrayPictures;
        }

        public static System.Drawing.Image FixedSize(Image image, int Width, int Height, bool needToFill)
        {
            #region calculations
            int sourceWidth = image.Width;
            int sourceHeight = image.Height;
            int sourceX = 0;
            int sourceY = 0;
            double destX = 0;
            double destY = 0;

            double nScale = 0;
            double nScaleW = 0;
            double nScaleH = 0;

            nScaleW = ((double)Width / (double)sourceWidth);
            nScaleH = ((double)Height / (double)sourceHeight);
            if (!needToFill)
            {
                nScale = Math.Min(nScaleH, nScaleW);
            }
            else
            {
                nScale = Math.Max(nScaleH, nScaleW);
                destY = (Height - sourceHeight * nScale) / 2;
                destX = (Width - sourceWidth * nScale) / 2;
            }

            if (nScale > 1)
                nScale = 1;

            int destWidth = (int)Math.Round(sourceWidth * nScale);
            int destHeight = (int)Math.Round(sourceHeight * nScale);
            #endregion

            System.Drawing.Bitmap bmPhoto = null;
            try
            {
                bmPhoto = new System.Drawing.Bitmap(destWidth + (int)Math.Round(2 * destX), destHeight + (int)Math.Round(2 * destY));
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("destWidth:{0}, destX:{1}, destHeight:{2}, desxtY:{3}, Width:{4}, Height:{5}",
                    destWidth, destX, destHeight, destY, Width, Height), ex);
            }
            using (System.Drawing.Graphics grPhoto = System.Drawing.Graphics.FromImage(bmPhoto))
            {
                grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grPhoto.CompositingQuality = CompositingQuality.HighQuality;
                grPhoto.SmoothingMode = SmoothingMode.HighQuality;

                Rectangle to = new System.Drawing.Rectangle((int)Math.Round(destX), (int)Math.Round(destY), destWidth, destHeight);
                Rectangle from = new System.Drawing.Rectangle(sourceX, sourceY, sourceWidth, sourceHeight);
                //Console.WriteLine("From: " + from.ToString());
                //Console.WriteLine("To: " + to.ToString());
                grPhoto.DrawImage(image, to, from, System.Drawing.GraphicsUnit.Pixel);
                //bmPhoto.Save(@"D:\final1.jpg");
                return bmPhoto;
            }
        }
    }
}
