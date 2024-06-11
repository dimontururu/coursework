namespace Игра_пазлы.Puzzle
{
    internal class CheckVictoryPuzzle
    {
        private CheckVictoryPuzzle() { }
        public static bool check(ArrayPiecePuzzle pieces) 
        {
            bool result = false;
            for (int i = 0; i < pieces.Width; i++)
            {
                for (int j = 0; j < pieces.Height; j++)
                {
                    foreach (var piece in pieces.array[0, 0].GluedPiecePuzzle)
                    {
                        if(i==0 && j==0)
                        {
                            result = true;
                            break;
                        }
                        result = false;
                        if (piece == pieces.array[i,j])
                        {
                            result = true;
                            break;
                        }
                    }
                    if (!result)
                        return result;
                }
            }
            return result;
        }
    }
}
