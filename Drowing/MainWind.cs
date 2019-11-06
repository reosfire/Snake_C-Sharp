using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drowing
{
    partial class mainWind : Form
    {
        static Timer timer = new Timer();
        RePainted r;
        bool Started = false;
        public GameArr gameArr;
        public static List<Direction> Moves { get; set; } = new List<Direction>();

        public mainWind()
        {
            InitializeComponent();
            r = SomeMethods.GetTupe<RePainted>(Controls.Cast<object>().ToArray())[0];
            gameArr = new GameArr(r.X, r.Y, this);
            timer.Tick += new EventHandler(Update);
            r.ChangeSize(16, 16);
            Width = 16 * 40 + 160; 
            Height = 16 * 40 + 64;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void settingsBtt_Click(object sender, EventArgs e)
        {
            Form SettingsWind = new settings();
            SettingsWind.ShowDialog();
        }
        private void StartGameBtt_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void StartStop()
        {
            Started = !Started;
            if (Started)
            {
                StartGameBtt.Text = "STOP";
            }
            else
            {
                StartGameBtt.Text = "START";
            }

            timer.Interval = 200;

            if (!Started)
            {
                timer.Stop();
                timer.Enabled = false;
            }
            else
            {
                gameArr = new GameArr(r.X, r.Y, this);
                timer.Start();
                timer.Enabled = true;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            Direction inputDir = TakeMove();
            if (gameArr.IsDie(inputDir))
            {
                StartStop();
            }
            gameArr.MoveSnake(inputDir);
            gameArr.EattenApple();

            scoreBox.Text = Convert.ToString(gameArr.Score);
            r.PaintFrame(gameArr);
        }

        private void mainWind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                AddMove(Direction.up);
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                AddMove(Direction.right);
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                AddMove(Direction.down);
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                AddMove(Direction.left);
            }
        }

        public static void AddMove(Direction dir)
        {
            if (Moves.Count < 3)
            {
                Moves.Add(dir);
                Moves[0] = dir;
            }
            else
            {
                Moves.RemoveRange(1, 2);
                Moves.Add(dir);
                Moves[0] = dir;
            }
        }
        public static Direction TakeMove()
        {
            if (Moves.Count == 1)
            {
                return Moves[0];
            }
            else
            {
                Direction retDir = Moves[Moves.Count - 1];
                Moves.RemoveAt(Moves.Count - 1);
                return retDir;
            }
        }
    }
}
