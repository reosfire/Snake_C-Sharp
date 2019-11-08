using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Drowing
{
    partial class RePainted : UserControl
    {
        public int X { get; private set; } = 16;
        public int Y { get; private set; } = 16;

        public RePainted()
        {
            InitializeComponent();
            X = Width / 40;
            Y = Height / 40;
        }

        public bool ChangeSize(int x, int y)
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            if ((x > 7 && resolution.Width > x * 40 + 160) && (y > 7 && resolution.Height > y * 40 + 64))
            {
                X = x;
                Y = y;
                Width = x * 40;
                Height = y * 40;
                return true;
            }
            return false;
        }
        public void PaintFrame(GameArr input, snake s)
        {
            Graphics g = Graphics.FromHwnd(Handle);
            Color AppleColor = Color.FromArgb(200, 20, 20);
            Color SnakeColor = Color.FromArgb(250, 250, 250);
            Color SnakeHeadColor = Color.FromArgb(40, 40, 40);

            for (int x = 1; x < input.X - 1; x++)
            {
                for (int y = 1; y < input.Y - 1; y++)
                {
                    switch (input.GameState[x, y].Type)
                    {
                        case PointType.Apple:
                            g.DrawImage(Properties.Resources.apple, x * 40 - 34 / 2 - 20, y * 40 - 34 / 2 - 20, 34, 34);
                            break;
                        case PointType.Snake:
                            int cubeSize = 26;// = GetCubeSize(s.Count, s.GetIndex(new Point(x, y)))*4 + 2;
                            paintRect(cubeSize, SnakeColor, x, y, g);
                            break;
                        case PointType.SnakeHead:
                            paintRect(30, SnakeHeadColor, x, y, g);
                            break;
                        case PointType.Empty:
                            g.FillRectangle(new SolidBrush(GetColor(x, y)), (x - 1) * 40, (y - 1) * 40, 40, 40);
                            break;
                    }
                }
            }
        }
        void paintRect(int Size, Color color, int x, int y, Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), x * 40 - Size / 2 - 20, y * 40 - Size / 2 - 20, Size, Size);
            g.DrawRectangle(new Pen(GetColor(x, y), 20 - Size / 2), x * 40 - Size / 2 - 20 + Size / 4 - 10, y * 40 - Size / 2 - 20 + Size / 4 - 10, 20 - Size / 2 + Size, 20 - Size / 2 + Size);
        }
        int GetCubeSize(int Count, int num)
        {
            float ret = 8f * num / Count;
            int revert = 9 - Convert.ToInt32(ret);
            return revert;
        }
        public Color GetColor(int x, int y)
        {
            if (x % 2 == y % 2)
            {
                return Color.FromArgb(92, 92, 92);
            }
            else
            {
                return Color.FromArgb(110, 110, 110);
            }
        }
    }
}
