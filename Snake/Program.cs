using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            // рамка
            HorizontalLine upLine = new HorizontalLine(0, 119, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 119, 28, '+');
            VerticalLine leftLine = new VerticalLine(1, 27, 0, '+');
            VerticalLine rigthLine = new VerticalLine(1, 27, 119, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();

            // змейка
            Snake snake = new Snake(new Point(10, 15, '*'), 10, Direction.Right);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
