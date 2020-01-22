using BattleShipProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GenerateAllShipT
{  
    private Random rnd;
    private List<int> ships;
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
    int boardSizeX;
    int boardSizeY;
    List<int> reservedY = new List<int>();


    public List<int> GenerateShips(int boardSizeX, int boardSizeY)
    {
        rnd = new Random();
        ships = new List<int>(getList(boardSizeX * boardSizeY));
        this.boardSizeX = boardSizeX;
        this.boardSizeY = boardSizeY;
        createShip(ship1Count, ship4Size);
        createShip(ship2Count, ship3Size);
        createShip(ship3Count, ship2Size);
        createShip(ship4Count, ship1Size);
        return ships;
    }


    public static int[] getList(int sizeList)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < sizeList; i++)
            list.Add(0);
        return list.ToArray();
    }

    private void createShip(int count, int size)
    {
        rnd = new Random();

        for (int i = 0; i < count; i++)
        {
            idxX = rnd.Next(0, boardSizeX - size);
            idxY = rnd.Next(0, boardSizeY - 1);
            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            reservedY.Add(idxY);
            int arrayIdx = idxY * boardSizeX + idxX;
            for (int j = 0; j < size; j++)
            {
                ships[arrayIdx + j] = size;
            }
        }
    }

}

