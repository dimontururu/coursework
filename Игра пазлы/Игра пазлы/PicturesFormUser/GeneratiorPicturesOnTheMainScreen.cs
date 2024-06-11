using System.Windows.Forms;
using Игра_пазлы.PicturesFormUser.PicturesFactory;
using Игра_пазлы.PicturesFormUser.PicturesOnTheMainScreenClick;

namespace Игра_пазлы.PicturesFormUser
{
    internal class GeneratiorPicturesOnTheMainScreen
    {
        public static void Generator(Control formOrPanel) 
        {
            PicturesOnTheMainScreen[]  array = new ArrayGeneratorPictures().Create(formOrPanel);
            foreach (PicturesOnTheMainScreen item in array)
            {
                item.pictureBox.Click += new PicturesOnTheMainScreenClicked(array, formOrPanel).PictureBoxClick;
            }
            AddArrayPicturesToControls.add(formOrPanel, array);
        }

    }
}
