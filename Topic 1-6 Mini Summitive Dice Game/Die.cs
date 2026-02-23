using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_1_6_Mini_Summitive_Dice_Game
{
    public class Die
    {
        private int _roll;
        private Random _generator;
        private ConsoleColor _color;


        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _color = ConsoleColor.Gray;
        }

        public Die(ConsoleColor color)
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _color = color;
        }

        public int Roll
        {
            get { return _roll; }
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public void DrawRoll()
        {
            Console.ForegroundColor = _color;
            if (_roll == 1)
            {
                Console.WriteLine("-------");
                Console.WriteLine("|     |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|     |");
                Console.WriteLine("-------");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-------");
                Console.WriteLine("| o   |");
                Console.WriteLine("|     |");
                Console.WriteLine("|   o |");
                Console.WriteLine("-------");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("-------");
                Console.WriteLine("| o   |");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|   o |");
                Console.WriteLine("-------");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-------");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|     |");
                Console.WriteLine("|o   o|");
                Console.WriteLine("-------");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-------");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|  o  |");
                Console.WriteLine("|o   o|");
                Console.WriteLine("-------");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-------");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|o   o|");
                Console.WriteLine("|o   o|");
                Console.WriteLine("-------");
            }


            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
