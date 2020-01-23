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


        public void ShotStats(String strzal)
        {
            if (strzal.Equals("X", StringComparison.CurrentCulture))
            {
                missedShot += 1;
            }
            else
            {
                hitShot += 1;
            }
        }

        public bool CheckWin(int sum)
        {
            if (hitShot == sum)
                return true;
            else
                return false;
        }

        public int GetHitShot()
        {
            return hitShot;
        }

        public int GetMissedShot()
        {
            return missedShot;
        }

        public void SetHitShot(int shot)
        {
            hitShot = shot;
        }

        public void SetMissedShot(int shot)
        {
            missedShot = shot;
        }

    }
}
