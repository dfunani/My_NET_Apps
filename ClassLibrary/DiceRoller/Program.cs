using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiceLibrary;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DiceLibrary.Dice.roll_dice(6).ToString());
        }
    }
}
