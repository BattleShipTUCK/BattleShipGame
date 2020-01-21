using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipProject
{

    class Stats
    {
        private int hitShot = 0;
        private int missedShot = 0;

        private void shotStats(String strzal)
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

        public int gethitShot()
        {
            return hitShot;
        }

        public int getmissedShot()
        {
            return missedShot;
        }

    }
}
