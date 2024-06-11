using System;
using System.Drawing;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class GluesThePieces
    {
        private static void addGluedPiecePuzzle(PiecePuzzle whereToAdd, PiecePuzzle whatToAdd)
        {
            whereToAdd.GluedPiecePuzzle.Add(whatToAdd);
        }

        private static void connectGluedPiece(PiecePuzzle one, PiecePuzzle two) 
        {
            if (!one.GluedPiecePuzzle.Contains(two))
            {
                if (one != two)
                    addGluedPiecePuzzle(one, two);
                foreach (PiecePuzzle pieceTwo in two.GluedPiecePuzzle)
                {
                    if (!one.GluedPiecePuzzle.Contains(pieceTwo))
                    {
                        if (one != pieceTwo)
                        {
                            addGluedPiecePuzzle(one, pieceTwo);
                            addGluedPiecePuzzle(pieceTwo, one);
                        }
                        foreach (PiecePuzzle pieceOne in one.GluedPiecePuzzle)
                        {
                            if (!pieceOne.GluedPiecePuzzle.Contains(pieceTwo))
                            {
                                if (pieceOne != pieceTwo)
                                    addGluedPiecePuzzle(pieceOne, pieceTwo);
                            }
                        }
                    }
                }
            }
        }
        private static void connectTwoGluedPiecePuzzle(PiecePuzzle one, PiecePuzzle two)
        {
            connectGluedPiece(one, two);
            connectGluedPiece(two, one);
        }

        private static bool canBeGlued(PiecePuzzle CantralPiece,PiecePuzzle sidePiece,string side)
        {
            switch (side)
            {
                case "left":
                    return Math.Abs(CantralPiece.rectanglePuzzlePieces.X - (sidePiece.rectanglePuzzlePieces.X + sidePiece.rectanglePuzzlePieces.Width)) < 5
                        && Math.Abs(CantralPiece.rectanglePuzzlePieces.Y - sidePiece.rectanglePuzzlePieces.Y) < 5;
                case "right":
                    return Math.Abs(sidePiece.rectanglePuzzlePieces.X - (CantralPiece.rectanglePuzzlePieces.X + CantralPiece.rectanglePuzzlePieces.Width)) < 5
                        && Math.Abs(CantralPiece.rectanglePuzzlePieces.Y - sidePiece.rectanglePuzzlePieces.Y) < 5;
                case "top":
                    return Math.Abs(CantralPiece.rectanglePuzzlePieces.Y - (sidePiece.rectanglePuzzlePieces.Y + sidePiece.rectanglePuzzlePieces.Height)) < 5
                        && Math.Abs(CantralPiece.rectanglePuzzlePieces.X - sidePiece.rectanglePuzzlePieces.X) < 5;
                case "lower":
                    return Math.Abs(sidePiece.rectanglePuzzlePieces.Y - (CantralPiece.rectanglePuzzlePieces.Y + CantralPiece.rectanglePuzzlePieces.Height)) < 5
                        && Math.Abs(CantralPiece.rectanglePuzzlePieces.X - sidePiece.rectanglePuzzlePieces.X) < 5;
                default:
                    return false;
            }
        }

        public static void bla(PiecePuzzle basicPiece,PiecePuzzle sidePiece,string side)
        {
            if(side=="left")
                if (!basicPiece.GluedPiecePuzzle.Contains(sidePiece))//слева
                    if (canBeGlued(basicPiece, sidePiece,"left"))
                    {
                        foreach (PiecePuzzle piece in sidePiece.GluedPiecePuzzle)
                        {
                            piece.rectanglePuzzlePieces = new Rectangle(piece.rectanglePuzzlePieces.X + (basicPiece.rectanglePuzzlePieces.X - (sidePiece.rectanglePuzzlePieces.Width + sidePiece.rectanglePuzzlePieces.X)), piece.rectanglePuzzlePieces.Y + (basicPiece.rectanglePuzzlePieces.Y - sidePiece.rectanglePuzzlePieces.Y), 0, 0);
                        }
                        sidePiece.rectanglePuzzlePieces = new Rectangle(basicPiece.rectanglePuzzlePieces.X - sidePiece.rectanglePuzzlePieces.Width, basicPiece.rectanglePuzzlePieces.Y, 0, 0);
                        connectTwoGluedPiecePuzzle(basicPiece, sidePiece);
                    }

            if (side == "top")
                if (!basicPiece.GluedPiecePuzzle.Contains(sidePiece))//слева
                    if (canBeGlued(basicPiece, sidePiece, "top"))
                    {
                        foreach (PiecePuzzle piece in sidePiece.GluedPiecePuzzle)
                        {
                            piece.rectanglePuzzlePieces = new Rectangle(piece.rectanglePuzzlePieces.X + (basicPiece.rectanglePuzzlePieces.X - sidePiece.rectanglePuzzlePieces.X),piece.rectanglePuzzlePieces.Y + (basicPiece.rectanglePuzzlePieces.Y - (sidePiece.rectanglePuzzlePieces.Height + sidePiece.rectanglePuzzlePieces.Y)), 0, 0);
                        }
                        sidePiece.rectanglePuzzlePieces = new Rectangle(basicPiece.rectanglePuzzlePieces.X, basicPiece.rectanglePuzzlePieces.Y - sidePiece.rectanglePuzzlePieces.Height, 0, 0);
                        connectTwoGluedPiecePuzzle(basicPiece, sidePiece);
                    }

            if (side == "right")
                if (!basicPiece.GluedPiecePuzzle.Contains(sidePiece))//слева
                    if (canBeGlued(basicPiece, sidePiece, "right"))
                    {
                        foreach (PiecePuzzle piece in sidePiece.GluedPiecePuzzle)
                        {
                            piece.rectanglePuzzlePieces = new Rectangle(piece.rectanglePuzzlePieces.X + (basicPiece.rectanglePuzzlePieces.X + basicPiece.rectanglePuzzlePieces.Width - sidePiece.rectanglePuzzlePieces.X), piece.rectanglePuzzlePieces.Y + (basicPiece.rectanglePuzzlePieces.Y - sidePiece.rectanglePuzzlePieces.Y), 0, 0);
                        }
                        sidePiece.rectanglePuzzlePieces = new Rectangle(basicPiece.rectanglePuzzlePieces.X + basicPiece.rectanglePuzzlePieces.Width, basicPiece.rectanglePuzzlePieces.Y, 0, 0);
                        connectTwoGluedPiecePuzzle(basicPiece, sidePiece);
                    }

            if (side == "lower")
                if (!basicPiece.GluedPiecePuzzle.Contains(sidePiece))//слева
                    if (canBeGlued(basicPiece, sidePiece, "lower"))
                    {
                        foreach (PiecePuzzle piece in sidePiece.GluedPiecePuzzle)
                        {
                            piece.rectanglePuzzlePieces = new Rectangle(piece.rectanglePuzzlePieces.X + (basicPiece.rectanglePuzzlePieces.X - sidePiece.rectanglePuzzlePieces.X), piece.rectanglePuzzlePieces.Y + (basicPiece.rectanglePuzzlePieces.Y + basicPiece.rectanglePuzzlePieces.Height -  sidePiece.rectanglePuzzlePieces.Y), 0, 0);
                        }
                        sidePiece.rectanglePuzzlePieces = new Rectangle(basicPiece.rectanglePuzzlePieces.X, basicPiece.rectanglePuzzlePieces.Y + sidePiece.rectanglePuzzlePieces.Height, 0, 0);
                        connectTwoGluedPiecePuzzle(basicPiece, sidePiece);
                    }
        }
    }
}
