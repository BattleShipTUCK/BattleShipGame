using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenerateAllShip
{  
    private Random rnd;
    private List<int> ships;

    public List<int> GenerateShips(int boardSizeX, int boardSizeY)
    {
        rnd = new Random();
        ships = new List<int>(getList(boardSizeX * boardSizeY));
        int ship4Size = 4;
        int ship4Count = 1;
        int ship3Size = 3;
        int ship3Count = 1;
        int ship2Size = 2;
        int ship2Count = 1;
        int ship1Size = 1;
        int ship1Count = 1;
        int idxX = 0;
        int idxY = 0;

        //Ship4
        List<int> reservedY = new List<int>();

        



        for (int i = 0; i < ship4Count; i++)
        {
            idxX = rnd.Next(0, boardSizeX - ship4Size);
            idxY = rnd.Next(0, boardSizeY - 1);
            reservedY.Add(idxY);
            int arrayIdx = idxY * boardSizeX + idxX;
            for (int j = 0; j < ship4Size; j++)
            {
                ships[arrayIdx + j] = ship4Size;
            }
        }

        //Ship3
        for (int i = 0; i < ship3Count; i++)
        {
            idxX = rnd.Next(0, boardSizeX - ship3Size);
            idxY = rnd.Next(0, boardSizeY - 1);
            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            reservedY.Add(idxY);
            for (int j = 0; j < ship3Size; j++)
            {
                ships[idxY * boardSizeX + idxX + j] = ship3Size;
            }
        }
        //Ship2
        for (int i = 0; i < ship2Count; i++)
        {
            idxX = rnd.Next(0, boardSizeX - ship2Size);
            idxY = rnd.Next(0, boardSizeY - 1);
            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            reservedY.Add(idxY);
            for (int j = 0; j < ship2Size; j++)
            {
                ships[idxY * boardSizeX + idxX + j] = ship2Size;
            }
        }

        // Ship1
        for (int i = 0; i < ship1Count; i++)
        {
            idxX = rnd.Next(0, boardSizeX - ship1Size);
            idxY = rnd.Next(0, boardSizeY - 1);
            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            for (int j = 0; j < ship1Size; j++)
            {
                ships[idxY * boardSizeX + idxX + j] = ship1Size;
            }
        }
        return ships;
    }


    public static int[] getList(int sizeList)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < sizeList; i++)
            list.Add(0);
        return list.ToArray();
    }

}

