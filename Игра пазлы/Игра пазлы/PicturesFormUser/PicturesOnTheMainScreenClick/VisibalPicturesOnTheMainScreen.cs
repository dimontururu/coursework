using System.Windows.Forms;

namespace Игра_пазлы.PicturesFormUser.PicturesOnTheMainScreenClick
{
    internal class VisibalPicturesOnTheMainScreen
    {
        public static void Hide(PicturesOnTheMainScreen[] array)
        {
            foreach (PicturesOnTheMainScreen control in array)
            {
                control.pictureBox.Visible = false;
                control.label.Visible = false;
            }
        }

        public static void Show(PicturesOnTheMainScreen[] array)
        {
            foreach (PicturesOnTheMainScreen control in array)
            {
                control.pictureBox.Visible = true;
                control.label.Visible = true;
            }
        }
    }
}
