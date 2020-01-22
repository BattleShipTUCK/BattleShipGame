using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipProject
{

    class StatsT
    {
        private int hitShot = 0;
        private int missedShot = 0;


        public void shotStats(String strzal)
        {
            if (strzal.Equals("X"))
            {
                missedShot += 1;
            }
            else
            {
                hitShot += 1;
            }
        }

        public bool checkWin(int sum)
        {
            if (hitShot == sum)
                return true;
            else
                return false;
        }

        public int gethitShot()
        {
            return hitShot;
        }

        public int getmissedShot()
        {
            return missedShot;
        }

        public void sethitShot(int shot)
        {
            hitShot = shot;
        }

        public void setmissedShot(int shot)
        {
            missedShot = shot;
        }

    }
}
