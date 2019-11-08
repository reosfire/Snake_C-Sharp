using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drowing
{
    class GameArr
    {
        public Gamepoint[,] GameState { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public snake Snake;
        private Point PApple;
        private mainWind Wind;
        public int Score { get; private set; } = 0;

        public GameArr(int x, int y, mainWind wind)
        {
            x += 2;
            y += 2;
            X = x;
            Y = y;
            Wind = wind;
            GameState = new Gamepoint[x, y];

            Clear_GameState();

            CreateStartSnake();
            CreateApple();
        }

        private void Clear_GameState()
        {
            for (int i = 0; i < Y; i++)
            {
                Gamepoint gp1 = new Gamepoint(PointType.Barrier, new Point(i, 0));
                GameState[i, 0] = gp1;
                Gamepoint gp2 = new Gamepoint(PointType.Barrier, new Point(i, X - 1));
                GameState[i, X - 1] = gp2;
            }
            for (int i = 1; i < Y - 1; i++)
            {
                Gamepoint gp1 = new Gamepoint(PointType.Barrier, new Point(0, i));
                GameState[0, i] = gp1;
                Gamepoint gp2 = new Gamepoint(PointType.Barrier, new Point(Y - 1, i));
                GameState[Y - 1, i] = gp2;
            }
            for (int i = 1; i < X - 1; i++)
            {
                for (int j = 1; j < Y - 1; j++)
                {
                    Gamepoint gp1 = new Gamepoint(PointType.Empty, new Point(i, j));
                    GameState[i, j] = gp1;
                }
            }
        }

        public void CreateApple()
        {
            Random rnd = new Random();

            while (true)
            {
                int outX = rnd.Next(1, X - 1);
                int outY = rnd.Next(1, Y - 1);

                if (GameState[outX, outY].Type == PointType.Empty)
                {
                    GameState[outX, outY].Type = PointType.Apple;
                    PApple = new Point(outX, outY);
                    return;
                }
            }
        }
        

        public void CreateStartSnake()
        {
            
            Random rnd = new Random();
            int HeadX = rnd.Next(4, X - 4);
            int HeadY = rnd.Next(4, Y - 4);
            List<Gamepoint> Body = new List<Gamepoint>();
            GameState[HeadX, HeadY].Type = PointType.SnakeHead;

            int direction = rnd.Next(1, 5);
            switch (direction)
            {
                case 1:
                    GameState[HeadX - 1, HeadY].Type = PointType.Snake;
                    GameState[HeadX - 2, HeadY].Type = PointType.Snake;
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX - 1, HeadY)));
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX - 2, HeadY)));
                    mainWind.AddMove(Direction.right);
                    break;
                case 2:
                    GameState[HeadX + 1, HeadY].Type = PointType.Snake;
                    GameState[HeadX + 2, HeadY].Type = PointType.Snake;
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX + 1, HeadY)));
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX + 2, HeadY)));
                    mainWind.AddMove(Direction.left);
                    break;
                case 3:
                    GameState[HeadX, HeadY - 1].Type = PointType.Snake;
                    GameState[HeadX, HeadY - 2].Type = PointType.Snake;
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX, HeadY - 1)));
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX, HeadY - 2)));
                    mainWind.AddMove(Direction.down);
                    break;
                case 4:
                    GameState[HeadX, HeadY + 1].Type = PointType.Snake;
                    GameState[HeadX, HeadY + 2].Type = PointType.Snake;
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX, HeadY + 1)));
                    Body.Add(new Gamepoint(PointType.Snake, new Point(HeadX, HeadY + 2)));
                    mainWind.AddMove(Direction.up);
                    break;
            }
            Snake = new snake(mainWind.Moves[0], new Gamepoint (PointType.SnakeHead, new Point (HeadX, HeadY)), Body.ToArray());
        }
        public void MoveSnake (Direction dir)
        {
            Clear_GameState();
            GameState[PApple.X, PApple.Y].Type = PointType.Apple;
            Snake.Move(dir);
            foreach (Gamepoint p in Snake.Body)
            {
                GameState[p.Point.X, p.Point.Y].Type = p.Type;
            }
        }
        public void EattenApple()
        {
            if (Snake.SnakeHead == PApple)
            {
                Gamepoint body = new Gamepoint(PointType.Snake, Snake.SnakeAssOFA);
                GameState[Snake.SnakeAssOFA.X, Snake.SnakeAssOFA.Y] = body;
                Snake.AddOne(body);
                GameState[Snake.SnakeHead.X, Snake.SnakeHead.Y].Type = PointType.SnakeHead;
                CreateApple();
                Score++;
            }
        }
        public bool IsDie(Direction dir)
        {
            Point p = Snake.nextFrameHeadPoint(dir);
            if (GameState[p.X,p.Y].Type == PointType.Barrier || GameState[p.X, p.Y].Type == PointType.Snake)
            {
                return true;
            }
            return false;
        }
    }
}