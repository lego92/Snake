using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            sym = point.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    x = x - offset;
                    break;
                case Direction.Right:
                    x = x + offset;
                    break;
                case Direction.Up:
                    x = x - offset;
                    break;
                case Direction.Down:
                    x = x + offset;
                    break;
            }
        }       

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return $"{x},{y},{sym}";
        }
    }
}
