using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static int declareSizeX = 4;
        static int declareSizeY = 4;
        private Board board = new Board(declareSizeX, declareSizeY);
        [TestMethod]
        public void TestMethod1()
        {
            int sizeX;
            int sizeY;
            sizeX = board.getboardSizeX();
            sizeY = board.getboardSizeY();
            Assert.AreEqual(declareSizeX, sizeX, "");
            Assert.AreEqual(declareSizeY, sizeY, "");
        }
    }
}
