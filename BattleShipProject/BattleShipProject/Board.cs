using System;
using System.Collections.Generic;

class Board
{
    private List<string> fieldList;
    private List<int> ships;
    private readonly int boardSizeX = 0;
    private readonly int boardSizeY = 0;
    private GenerateAllShip generateAllShip;


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
        generateAllShip = new GenerateAllShip();
        ships = generateAllShip.GenerateShips(boardSizeX,boardSizeY);

        return fieldList;
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
    public List<string> GetPointList()
    {
        return fieldList;
    }

    public int GetboardSizeX()
    {
        return boardSizeX;
    }

    public int GetboardSizeY()
    {
        return boardSizeY;
    }

}

