using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


class Board
{
    private List<string> fieldList;
    private List<int> ships;
    private int boardSizeX = 0;
    private int boardSizeY = 0;
    private Random rnd;


    private int ship1Count = 1;
    private int ship2Count = 1;
    private int ship3Count = 1;
    private int ship4Count = 1;

    private int ship1Size = 1;
    private int ship2Size = 2;
    private int ship3Size = 3;
    private int ship4Size = 4;


    public Board(int boardSizeX, int boardSizeY)
    {
        this.boardSizeX = boardSizeX;
        this.boardSizeY = boardSizeY;
        rnd = new Random();

    }

    public List<String> InitializeBoard()
    {
        fieldList = new List<string>();
        for (int k = 0; k < boardSizeX * boardSizeY; k++)
        {
            fieldList.Add("?");
        }
        GenerateShips();
        return fieldList;
    }

    public static int[] getList(int sizeList)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < sizeList; i++)
            list.Add(0);
        return list.ToArray();
    }

    private void GenerateShips()
    {
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

    public string VerifyShot(int row, int col)
    {
        int arrayIndex = row * boardSizeX + col;
        switch (ships[arrayIndex])
        {
            case 1:
                return "S1";
            case 2:
                return "S2";
            case 3:
                return "S3";
            case 4:
                return "S4";
            default:
                return "X";
        }
    }
    public List<string> getPointList()
    {
        return fieldList;
    }

    public int getboardSizeX()
    {
        return boardSizeX;
    }

    public int getboardSizeY()
    {
        return boardSizeY;
    }
}

