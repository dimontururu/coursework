using System.Drawing;
using System.IO;

namespace Игра_пазлы
{
    internal class GetAnArrayOfImages
    {
        public static Image[] GetArray(string ThePathToTheFolder)
        {
            string[] imageFiles = Directory.GetFiles(ThePathToTheFolder);
            Image[] array = new Image[imageFiles.Length];
            int i = 0;
            foreach (string imageFile in imageFiles)
            {
                array[i]= Image.FromFile(imageFile);
                i++;
            }
            return array;
        }
    }
}
