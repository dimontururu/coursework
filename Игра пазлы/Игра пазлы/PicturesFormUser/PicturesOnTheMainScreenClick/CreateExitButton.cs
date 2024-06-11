using System.Drawing;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class CreateExitButton
    {
        private CreateExitButton() { }

        public static PictureBox Create()
        {
            PictureBox buttonExit = new PictureBox();
            bool blue=false;

            buttonExit.Paint += (s, e) =>
            {
                PointF[] PointArray = new PointF[]
                {
                    new Point (0,((PictureBox)s).Height / 2),
                    new Point(((PictureBox)s).Width / 3,0),
                    new Point(((PictureBox)s).Width / 3,((PictureBox)s).Height/3),
                    new Point(((PictureBox)s).Width ,((PictureBox)s).Height/3),
                    new Point(((PictureBox)s).Width ,((PictureBox)s).Height/3+((PictureBox)s).Height/3),
                    new Point(((PictureBox)s).Width/3 ,((PictureBox)s).Height/3+((PictureBox)s).Height/3),
                    new Point(((PictureBox)s).Width/3 ,((PictureBox)s).Height),
                    new Point(0,((PictureBox)s).Height / 2)
                };

                SolidBrush solidBrush;

                if (blue)
                    solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
                else
                    solidBrush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPolygon(solidBrush, PointArray);
                e.Graphics.DrawPolygon(new Pen(Color.Black), PointArray);
            };

            buttonExit.MouseEnter += (s, e) => {blue = true; buttonExit.Invalidate(); };
            buttonExit.MouseLeave += (s, e) => { blue = false; buttonExit.Invalidate(); };
            buttonExit.BackColor= Color.Transparent;
            return buttonExit;
        }
    }
}
