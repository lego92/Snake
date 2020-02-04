using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine horizontalLine = new HorizontalLine(5,10,8,'+');
            horizontalLine.Draw();

            VerticalLine verticalLine = new VerticalLine(10, 20, 25, '^');
            verticalLine.Draw();

            Console.ReadLine();
        }
    }
}
