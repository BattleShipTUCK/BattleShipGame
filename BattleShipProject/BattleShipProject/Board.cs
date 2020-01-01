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
    private List<string> ships;
    private int boardSizeX = 0;
    private int boardSizeY = 0;
    private Random rnd;


    private int ship1Count = 0;
    private int ship2Count = 0;
    private int ship3Count = 0;
    private int ship4Count = 0;


    public Board(int boardSizeX, int boardSizeY, int ship1, int ship2, int ship3, int ship4)
    {
        this.boardSizeX = boardSizeX;
        this.boardSizeY = boardSizeY;
        rnd = new Random();
        ship1Count = ship1;
        ship2Count = ship2;
        ship3Count = ship3;
        ship4Count = ship4;
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

    private void GenerateShips()
    {
        ships = new List<string>()
            {
                "", "", "", "", "",
                "", "", "", "", "",
                "", "", "", "", "",
                "", "", "", "", "",
                "", "", "", "", "",
            };
        List<int> reservedY = new List<int>();


        //Ship4 x1
        int idxX = rnd.Next(0, boardSizeX - 4);
        int idxY = rnd.Next(0, boardSizeY - 1);
        reservedY.Add(idxY);

        int arrayIdx = idxY * boardSizeX + idxX;

        for (int i = 0; i < 4; i++)
        {
            ships.Insert(arrayIdx + i, "S4");
        }


        //Ship3 x2
        for (int i = 0; i < 1; i++)
        {
            idxX = rnd.Next(0, boardSizeX - 3);

            idxY = rnd.Next(0, boardSizeY - 1);

            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            reservedY.Add(idxY);

            for (int j = 0; j < 3; j++)
            {
                ships.Insert(idxY * boardSizeX + idxX + j, "S3");
            }
        }

        for (int i = 0; i < 2; i++)
        {
            idxX = rnd.Next(0, boardSizeX - 2);

            idxY = rnd.Next(0, boardSizeY - 1);

            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            //reservedY.Add(idxY);

            for (int j = 0; j < 2; j++)
            {
                ships.Insert(idxY * boardSizeX + idxX + j, "S2");
            }
        }

        for (int i = 0; i < 1; i++)
        {
            idxX = rnd.Next(0, boardSizeX - 1);

            idxY = rnd.Next(0, boardSizeY - 1);

            while (reservedY.Any(x => x == idxY))
            {
                idxY = rnd.Next(0, boardSizeY - 1);
            }
            //reservedY.Add(idxY);

            for (int j = 0; j < 1; j++)
            {
                ships.Insert(idxY * boardSizeX + idxX + j, "S1");
            }
        }


    }


    public string VerifyShot(int row, int col)
    {
        int arrayIndex = row * boardSizeX + col;
        switch (ships[arrayIndex])
        {
            case "S1":
                return "S1";
            case "S2":
                return "S2";
            case "S3":
                return "S3";
            case "S4":
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

