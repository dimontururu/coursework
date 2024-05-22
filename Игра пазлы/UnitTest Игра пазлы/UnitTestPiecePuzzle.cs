using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Игра_пазлы;

namespace UnitTest_Игра_пазлы
{
    [TestClass]
    public class UnitTestPiecePuzzle
    {
        [TestMethod]
        public void Constructor_PiecePuzzle_null_return_error()
        {
            try
            {
                PiecePuzzle X = new PiecePuzzle(null, new Rectangle());
            }
            catch 
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Constructor_PiecePuzzle_sizeBitmap_not_equal_sizeRectangle_return_error()
        {
            Bitmap bitmap = new Bitmap(2,3);
            Rectangle rectangle = new Rectangle(0,0,1,1);

                PiecePuzzle X = new PiecePuzzle(bitmap, rectangle);

        }
    }
}
