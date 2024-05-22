namespace Игра_пазлы
{
    internal class ArrayPiecePuzzle
    {
        public readonly int Width;
        public readonly int Height;

        public PiecePuzzle[,] array;

        public ArrayPiecePuzzle(int width, int height, PiecePuzzle[,] array)
        {
            Width = width;
            Height = height;
            this.array = array;
        }
    }
}
