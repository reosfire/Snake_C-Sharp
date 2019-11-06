using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drowing
{
    enum Direction { up, right, down, left }
    
    class snake
    {
        public bool IsDie { get; private set; } = false; 
        public int Count { get; private set; }
        public List<Gamepoint> Body { get; private set; } = new List<Gamepoint>();
        public Direction Direction { get; private set; }
        public Point SnakeHead;
        public Point SnakeAssOFA;

        public snake(Direction direction, Gamepoint Head, Gamepoint[] body)
        {
            Direction = direction;
            Body.Add(Head);
            SnakeHead = Head.Point;
            foreach (Gamepoint gp in body)
            {
                Body.Add(gp);
            }
            SnakeAssOFA = body[body.Length - 1].Point;
        }

        public void Move(Direction direction)
        {
            if (invertedDirection(Direction, direction))
            {
                direction = Direction;
            }
            SnakeAssOFA = Body[Body.Count - 1].Point;
            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i].Point = Body[i - 1].Point;
            }
            Body[0].Point = nextFrameHeadPoint(direction);
            SnakeHead = Body[0].Point;
            Direction = direction;
        }
        public bool invertedDirection(Direction d1, Direction d2)
        {
            if (d1 == Direction.up && d2 == Direction.down || d1 == Direction.down && d2 == Direction.up || d1 == Direction.left && d2 == Direction.right || d1 == Direction.right && d2 == Direction.left)
            {
                return true;
            }
            return false;
        }
        public void AddOne (Gamepoint BodyElem)
        {
            Body.Add(BodyElem);
        }

        public Point nextFrameHeadPoint (Direction dir)
        {
            Point outP;
            if (invertedDirection(Direction, dir))
            {
                dir = Direction;
            }
            switch (dir)
            {
                case Direction.up:
                    outP = new Point(Body[0].Point.X, Body[0].Point.Y - 1);
                    break;
                case Direction.right:
                    outP = new Point(Body[0].Point.X + 1, Body[0].Point.Y);
                    break;
                case Direction.down:
                    outP = new Point(Body[0].Point.X, Body[0].Point.Y + 1);
                    break;
                case Direction.left:
                    outP = new Point(Body[0].Point.X - 1, Body[0].Point.Y);
                    break;
                default:
                    outP = new Point(Body[0].Point.X, Body[0].Point.Y);
                    break;
            }
            return outP;
        }
    }
}
