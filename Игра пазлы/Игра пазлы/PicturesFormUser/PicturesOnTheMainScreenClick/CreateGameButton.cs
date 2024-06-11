using System.Drawing;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class CreateGameButton
    {
        private CreateGameButton() { }

        public static PictureBox Create()
        {
            PictureBox buttonGame = new PictureBox();
            bool blue = false;

            buttonGame.Paint += (s, e) =>
            {
                PointF[] PointArray = new PointF[]
                {
                    new Point(),
                    new Point(buttonGame.Width,buttonGame.Height/2),
                    new Point(0,buttonGame.Height),
                    new Point()
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

            buttonGame.MouseEnter += (s, e) => { blue = true; buttonGame.Invalidate(); };
            buttonGame.MouseLeave += (s, e) => { blue = false; buttonGame.Invalidate(); };
            buttonGame.BackColor = Color.Transparent;
            return buttonGame;
        }
    }
}
