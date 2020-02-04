﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yup, int ydown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yup; y <= ydown; y++)
            {
                Point point = new Point(x, y, sym);
                pList.Add(point);
            }
        }       
    }
}
