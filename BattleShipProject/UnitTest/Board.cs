using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Board
{
    private List<string> fieldList;
    private List<int> ships;
    private int boardSizeX = 0;
    private int boardSizeY = 0;


    public Board(int boardSizeX, int boardSizeY)
    {
        this.boardSizeX = boardSizeX;
        this.boardSizeY = boardSizeY;
   }

    public List<String> InitializeBoard()
    {
        fieldList = new List<string>();
        for (int k = 0; k < boardSizeX * boardSizeY; k++)
        {
            fieldList.Add("?");
        }

        //generateAllShip = new GenerateAllShip();
        //GenerateShips(1,1,1,1);

        return fieldList;
    }

    public static int[] getList(int sizeList)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < sizeList; i++)
            list.Add(0);
        return list.ToArray();
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

