using System;
using System.Collections.Generic;
using System.Drawing;

namespace Игра_пазлы
{
    internal class PiecePuzzle
    {
        private readonly Bitmap _bitmapPuzzlePieces;
        private Rectangle _rectanglePuzzlePieces;
        public List<PiecePuzzle> GluedPiecePuzzle = new List<PiecePuzzle>();

        public Bitmap bitmapPuzzlePieces => _bitmapPuzzlePieces;
        public Rectangle rectanglePuzzlePieces 
        { 
            get=>_rectanglePuzzlePieces;
            set 
            {
                _rectanglePuzzlePieces = new Rectangle(value.Location,_rectanglePuzzlePieces.Size);
            } 
        }
        public PiecePuzzle(Bitmap bitmapPuzzlePieces, Rectangle rectanglePuzzlePieces) 
        {
            if(bitmapPuzzlePieces == null)
                throw new ArgumentNullException();

            this._bitmapPuzzlePieces = bitmapPuzzlePieces;
            this._rectanglePuzzlePieces = rectanglePuzzlePieces;
        }
    }
}
