using System.Windows.Forms;

namespace Игра_пазлы.PicturesFormUser
{
    internal class AddArrayPicturesToControls
    {
        public static void add(Control formOrPanel, PicturesOnTheMainScreen[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                formOrPanel.Controls.Add(array[i].pictureBox);
                formOrPanel.Controls.Add(array[i].label);
            }
        }
    }
}
