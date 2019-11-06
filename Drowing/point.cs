using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drowing
{
    enum PointType {Empty, Apple, Snake, SnakeHead, Barrier}

    class Gamepoint
    {
        public PointType Type { get; set; }
        public Point Point { get; set; }
        
        public Gamepoint (PointType t, Point p)
        {
            Type = t;
            Point = p;
        }
    }
}
