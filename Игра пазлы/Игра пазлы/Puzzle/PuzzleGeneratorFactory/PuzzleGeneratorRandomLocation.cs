using System;
using System.Drawing;

namespace Игра_пазлы
{
    internal class PuzzleGeneratorRandomLocation:IArrayPiecePuzzleFactory
    {
        public ArrayPiecePuzzle Create(int Width,int Height,Bitmap PuzzlePicture)
        {
            if (Width <= 0 || Height <= 0 || PuzzlePicture == null)
                throw new Exception("Недопустимое значение");
            PiecePuzzle[,] piecePuzzles = new PiecePuzzle[Height, Width];
            Random rnd = new Random();

            int pieceWidth = PuzzlePicture.Width / Width;
            int pieceHeight = PuzzlePicture.Height / Height;

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Bitmap bitmapToPiece = new Bitmap(pieceWidth, pieceHeight);
                    Graphics piece = Graphics.FromImage(bitmapToPiece);
                    piece.DrawImage
                    (
                        PuzzlePicture,
                        new Rectangle(0, 0, pieceWidth, pieceHeight),
                        new Rectangle(j * pieceWidth, i * pieceHeight, pieceWidth, pieceHeight),
                        GraphicsUnit.Pixel
                    );
                    piece.Dispose();

                    Rectangle rectangleToPiece= new Rectangle(rnd.Next(0, PuzzlePicture.Width - pieceWidth), rnd.Next(0, PuzzlePicture.Height - pieceHeight), pieceWidth, pieceHeight);
                    piecePuzzles[i,j] = new PiecePuzzle(bitmapToPiece,rectangleToPiece);
                }
            }
            return new ArrayPiecePuzzle(Width,Height,piecePuzzles);
        }
    }
}
