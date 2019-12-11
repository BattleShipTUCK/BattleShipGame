using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipProject
{
    class Board
    {
        private List<Point> fieldList = new List<Point>();
        private int boardSizeX = 0;
        private int boardSizeY = 0;

        public Board(int boardSizeX, int boardSizeY)
        {
            this.boardSizeX = boardSizeX;
            this.boardSizeY = boardSizeY;
            for (int y = 0; y < boardSizeX; y++)
            {
                for (int x = 0; x < boardSizeY; x++)
                {
                    fieldList.Add(new Point(x, y));
                }
            }
        }
        public List<Point> getPointList()
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
}
