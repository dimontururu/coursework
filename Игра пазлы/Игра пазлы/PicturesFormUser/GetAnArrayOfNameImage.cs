using System.IO;

namespace Игра_пазлы.PicturesFormUser
{
    internal class GetAnArrayOfNameImage
    {
        public static string[] GetArray(string ThePathToTheFolder)
        {
            string[] imageFiles = Directory.GetFiles(ThePathToTheFolder);
            string[] array = new string[imageFiles.Length];
            int i = 0;
            foreach (string imageFile in imageFiles)
            {
                for (int j = 0; j < Path.GetFileName(imageFile).Length; j++)
                {
                    if (Path.GetFileName(imageFile)[j] == '.')
                        break;
                    array[i] += Path.GetFileName(imageFile)[j];
                }
                i++;
            }
            return array;
        }
    }
}
