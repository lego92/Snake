﻿using System;
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
            Point tailPoint = new Point(10, 15, '*');
            Snake snake = new Snake(tailPoint, 5, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(30, 120, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
