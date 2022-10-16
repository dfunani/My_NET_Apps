using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLibrary
{
    public static class Dice
    {
        public static int roll_dice(this int num)
        {
            Random randNum = new Random();
            return randNum.Next(1, num + 1);

        }
    }
}
