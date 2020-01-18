using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipProject
{
    class GenerateAllShip
    {
        private List<int> ships;
        private int ship1Count = 1;
        private int ship2Count = 1;
        private int ship3Count = 1;
        private int ship4Count = 1;

        private int ship1Size = 1;
        private int ship2Size = 2;
        private int ship3Size = 3;
        private int ship4Size = 4;
        private Random rnd;


        private void GenerateShips(int boardSizeX, int boardSizeY)
        {
            rnd = new Random();
            ships = new List<int>(getList(boardSizeX * boardSizeY));
            int idxX = 0;
            int idxY = 0;

            //Ship4
            List<int> reservedY = new List<int>();
            for (int i = 0; i < ship4Count; i++)
            {
                idxX = rnd.Next(0, boardSizeX - 4);
                idxY = rnd.Next(0, boardSizeY - 1);
                reservedY.Add(idxY);
                int arrayIdx = idxY * boardSizeX + idxX;
                for (int j = 0; j < ship4Size; j++)
                {
                    ships[arrayIdx + j] = 4;
                }
            }

            //Ship3
            for (int i = 0; i < ship3Count; i++)
            {
                idxX = rnd.Next(0, boardSizeX - 3);
                idxY = rnd.Next(0, boardSizeY - 1);
                while (reservedY.Any(x => x == idxY))
                {
                    idxY = rnd.Next(0, boardSizeY - 1);
                }
                reservedY.Add(idxY);
                for (int j = 0; j < ship3Size; j++)
                {
                    ships[idxY * boardSizeX + idxX + j] = 3;
                }
            }
            //Ship2
            for (int i = 0; i < ship2Count; i++)
            {
                idxX = rnd.Next(0, boardSizeX - 2);
                idxY = rnd.Next(0, boardSizeY - 1);
                while (reservedY.Any(x => x == idxY))
                {
                    idxY = rnd.Next(0, boardSizeY - 1);
                }
                reservedY.Add(idxY);
                for (int j = 0; j < ship2Size; j++)
                {
                    ships[idxY * boardSizeX + idxX + j] = 2;
                }
            }

            // Ship1
            for (int i = 0; i < ship1Count; i++)
            {
                idxX = rnd.Next(0, boardSizeX - 1);
                idxY = rnd.Next(0, boardSizeY - 1);
                while (reservedY.Any(x => x == idxY))
                {
                    idxY = rnd.Next(0, boardSizeY - 1);
                }
                for (int j = 0; j < ship1Size; j++)
                {
                    ships[idxY * boardSizeX + idxX + j] = 2;
                }
            }
        }
        public static int[] getList(int sizeList)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < sizeList; i++)
                list.Add(0);
            return list.ToArray();
        }
    }
}
