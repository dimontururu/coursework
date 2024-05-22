using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class CreatePictureBoxForFullControl
    {
        private CreatePictureBoxForFullControl() { }

        public static PictureBox Create(Control control)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = control.Width;
            pictureBox.Height = control.Height;
            control.Controls.Add(pictureBox);
            return pictureBox;
        }
    }
}
