using BattleShipProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestMethod
    {
        private List<int> ships;
        static int declareSizeX = 10;
        static int declareSizeY = 10;
        int win = 10;
        private List<string> fieldList;
        private BoardT boardT = new BoardT(declareSizeX, declareSizeY);
        private GenerateAllShipT generateAllShipT = new GenerateAllShipT();
        private StatsT statsT  = new StatsT();



        [TestMethod]
        public void BoardSizeTest()
        {
            int sizeX;
            int sizeY;
            sizeX = boardT.getboardSizeX();
            sizeY = boardT.getboardSizeY();
            Assert.AreEqual(declareSizeX, sizeX, "");
            Assert.AreEqual(declareSizeY, sizeY, "");
        }

        [TestMethod]
        public void InitializeBoardTest()
        {
            fieldList = boardT.InitializeBoard();

            for (int i = 0; i > declareSizeX * declareSizeY; i++)
            {
                Assert.AreEqual(fieldList[0], "?", "");
            }
        }

        [TestMethod]
        public void VerifyShotTest()
        {
            boardT.InitializeBoard();
            for (int i = 0; i < declareSizeX; i++)
            {
                for (int j = 0; j < declareSizeY; j++)
                {
                    Assert.IsTrue(string.Equals(boardT.VerifyShot(i, j), "X")
                               || string.Equals(boardT.VerifyShot(i, j), "S4")
                               || string.Equals(boardT.VerifyShot(i, j), "S3")
                               || string.Equals(boardT.VerifyShot(i, j), "S2")
                               || string.Equals(boardT.VerifyShot(i, j), "S1"));
                }
            }
        }

        [TestMethod]
        public void GenerateShipsTest()
        {
            ships = generateAllShipT.GenerateShips(declareSizeX, declareSizeY);

            for (int i = 0; i < declareSizeY * declareSizeX; i++)
            {
                Assert.IsTrue(string.Equals(ships[i], 0)
                           || string.Equals(ships[i], 4)
                           || string.Equals(ships[i], 3)
                           || string.Equals(ships[i], 2)
                           || string.Equals(ships[i], 1));
            }
        }

        [TestMethod]
        public void StatsAndCheckWinTest()
        {
            int sumShot = 0;
            boardT.InitializeBoard();
            for (int i = 0; i < declareSizeX; i++)
            {
                for (int j = 0; j < declareSizeY; j++)
                {
                    string shotResult = boardT.VerifyShot(i, j);
                    statsT.shotStats(shotResult);
                }
                sumShot = Convert.ToInt32(statsT.gethitShot()) + Convert.ToInt32(statsT.getmissedShot());
            }
            Assert.IsTrue(statsT.checkWin(win))
            ;            Assert.AreEqual(sumShot, declareSizeX * declareSizeY, "");
        }
    }

}
