using System.Drawing;

namespace Игра_пазлы
{
    internal interface IArrayPiecePuzzleFactory
    {
        ArrayPiecePuzzle Create(int Width, int Height, Bitmap PuzzlePicture);
    }
}
