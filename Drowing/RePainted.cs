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
        public void PaintFrame(GameArr input)
        {
            Graphics g = Graphics.FromHwnd(Handle);
            Color AppleColor = Color.FromArgb(200, 20, 20);
            Color SnakeColor = Color.FromArgb(20, 200, 20);
            Color SnakeHeadColor = Color.FromArgb(20, 80, 20);

            for (int x = 1; x < input.X - 1; x++)
            {
                for (int y = 1; y < input.Y - 1; y++)
                {
                    switch (input.GameState[x, y].Type)
                    {
                        case PointType.Apple:
                            g.FillEllipse(new SolidBrush(AppleColor), (x - 1) * 40 + 2, (y - 1) * 40 + 2, 34, 34);
                            break;
                        case PointType.Snake:
                            g.FillRectangle(new SolidBrush(SnakeColor), (x - 1) * 40 + 5, (y - 1) * 40 + 5, 30, 30);
                            g.DrawRectangle(new Pen(GetColor(x, y), 5), (x - 1) * 40  + 2, (y - 1) * 40 + 2, 35, 35);
                            break;
                        case PointType.SnakeHead:
                            g.FillRectangle(new SolidBrush(SnakeHeadColor), (x - 1) * 40 + 2, (y - 1) * 40 + 2, 36, 36 );
                            g.DrawRectangle(new Pen(Color.FromArgb(10,10,100), 3), (x - 1) * 40 + 3, (y - 1) * 40 + 3, 35, 35);
                            break;
                        case PointType.Empty:
                            g.FillRectangle(new SolidBrush(GetColor(x, y)), (x - 1) * 40, (y - 1) * 40, 40, 40);
                            break;
                    }
                }
            }
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
