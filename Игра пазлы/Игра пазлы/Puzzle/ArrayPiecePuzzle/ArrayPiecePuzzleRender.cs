
using System;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class ArrayPiecePuzzleRender
    {
        private ArrayPiecePuzzleRender() { }
        public static void render(ArrayPiecePuzzle array, PaintEventArgs e)
        {
            for (int i = 0; i < array.Height; i++)
            {
                for (int j = 0; j < array.Width; j++)
                {
                    PiecePuzzle currentPiece = array.array[i,j];

                    //Рисуем изображение текущего фрагмента пазла используя прямоугольник
                    e.Graphics.DrawImage(
                        currentPiece.bitmapPuzzlePieces,
                        currentPiece.rectanglePuzzlePieces.X,
                        currentPiece.rectanglePuzzlePieces.Y,
                        currentPiece.rectanglePuzzlePieces.Width,
                        currentPiece.rectanglePuzzlePieces.Height);
                }
            }
        }
    }
}
