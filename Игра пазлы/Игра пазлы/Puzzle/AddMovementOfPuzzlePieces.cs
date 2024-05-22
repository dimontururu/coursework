using System.Drawing;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class AddMovementOfPuzzlePieces
    {
        private ArrayPiecePuzzle array;
        private bool dragPiecePuzzle;
        private Point fromTheUpperRoomToTheMouse;
        private Point mousePositionWhenClickingOnAPuzzlePiece;
        private PiecePuzzle currentPiece;
        private Point currentPieceArrayPosition; 
        public AddMovementOfPuzzlePieces(PictureBox pictureBox, ArrayPiecePuzzle array) 
        {
            this.array = array;
            pictureBox.Paint += (s, e) => { ArrayPiecePuzzleRender.render(array, e); };
            pictureBox.MouseDown += pictureBoxPuzzle_MouseDown;
            pictureBox.MouseMove += pictureBoxPuzzle_MouseMove;
            pictureBox.MouseUp += pictureBoxPuzzle_MouseUp;
        }

        private void pictureBoxPuzzle_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = array.Height-1; i > -1; i--)
            {
                for (int j = array.Width-1; j > -1; j--)
                {
                    currentPiece = array.array[i, j];
                    if ((e.X < currentPiece.rectanglePuzzlePieces.X + currentPiece.rectanglePuzzlePieces.Width) && (e.X > currentPiece.rectanglePuzzlePieces.X))
                    {
                        if ((e.Y < currentPiece.rectanglePuzzlePieces.Y + currentPiece.rectanglePuzzlePieces.Height) && (e.Y > currentPiece.rectanglePuzzlePieces.Y))
                        {
                            dragPiecePuzzle = true;
                            fromTheUpperRoomToTheMouse = e.Location;
                            fromTheUpperRoomToTheMouse.X -= currentPiece.rectanglePuzzlePieces.X;
                            fromTheUpperRoomToTheMouse.Y -= currentPiece.rectanglePuzzlePieces.Y;
                            mousePositionWhenClickingOnAPuzzlePiece = e.Location;
                            currentPieceArrayPosition = new Point(j,i);
                            return;
                        }
                    }
                }
            }
        }

        private void pictureBoxPuzzle_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.ClientRectangle.Contains(pictureBox.PointToClient(Cursor.Position)))
            {
                if (dragPiecePuzzle)
                {

                    currentPiece.rectanglePuzzlePieces = new Rectangle(e.X - fromTheUpperRoomToTheMouse.X, e.Y - fromTheUpperRoomToTheMouse.Y, currentPiece.rectanglePuzzlePieces.Width, currentPiece.rectanglePuzzlePieces.Height);

                    foreach (PiecePuzzle piece in currentPiece.GluedPiecePuzzle)
                    {
                        piece.rectanglePuzzlePieces = new Rectangle(piece.rectanglePuzzlePieces.X + e.X - mousePositionWhenClickingOnAPuzzlePiece.X, piece.rectanglePuzzlePieces.Y + e.Y - mousePositionWhenClickingOnAPuzzlePiece.Y, 0, 0);
                    }

                    if (currentPieceArrayPosition.X - 1 > -1)
                        GluesThePieces.bla(currentPiece, array.array[currentPieceArrayPosition.Y, currentPieceArrayPosition.X - 1], "left");
                    if (currentPieceArrayPosition.Y - 1 > -1)
                        GluesThePieces.bla(currentPiece, array.array[currentPieceArrayPosition.Y - 1, currentPieceArrayPosition.X], "top");
                    if (currentPieceArrayPosition.X + 1 < array.Width)
                        GluesThePieces.bla(currentPiece, array.array[currentPieceArrayPosition.Y, currentPieceArrayPosition.X + 1], "right");
                    if (currentPieceArrayPosition.Y + 1 < array.Height)
                        GluesThePieces.bla(currentPiece, array.array[currentPieceArrayPosition.Y + 1, currentPieceArrayPosition.X], "lower");

                    pictureBox.Invalidate();
                    mousePositionWhenClickingOnAPuzzlePiece = e.Location;
                }
            }
            else
                pictureBoxPuzzle_MouseUp(null,null);
        }

        private void pictureBoxPuzzle_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragPiecePuzzle)
            {
                mousePositionWhenClickingOnAPuzzlePiece = Point.Empty;
                dragPiecePuzzle = false;
            }
        }
    }
}
