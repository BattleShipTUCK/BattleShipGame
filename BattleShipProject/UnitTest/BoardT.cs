using System;
using System.Collections.Generic;

class BoardT
{
    private List<string> fieldList;
    private List<int> ships;
    private int boardSizeX = 0;
    private int boardSizeY = 0;
    private Random rnd;
    private GenerateAllShipT generateAllShip;


    public BoardT(int boardSizeX, int boardSizeY)
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
        generateAllShip = new GenerateAllShipT();
        ships = generateAllShip.GenerateShips(boardSizeX, boardSizeY);

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

