using System;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal interface IArrayPicturesFactory
    {
        PicturesOnTheMainScreen[] Create(Control FormOrPanel, EventHandler pictureBoxClick = null);
    }
}
