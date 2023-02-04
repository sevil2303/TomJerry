using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomJerry.Properties;

namespace TomJerry
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer(Properties.Resources.Tom_And_Jerry);
        public Form1()
        {
            InitializeComponent();
            music.PlayLooping();
            Bitmap tom = new Bitmap(Resources.tom_and_jerry_PNG58__1_);
            this.Cursor = new Cursor(tom.GetHicon());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void jerryBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
            }
            Button newJerryBtn = new Button();
            newJerryBtn.BackgroundImage = new Bitmap(Resources.pngimg_com___tom_and_jerry_PNG2__1_);
            newJerryBtn.BackColor = Color.Transparent;
            newJerryBtn.FlatStyle = FlatStyle.Flat;
            newJerryBtn.Size = jerryBtn.Size;
            newJerryBtn.FlatAppearance.BorderSize = jerryBtn.FlatAppearance.BorderSize;
            newJerryBtn.FlatAppearance.BorderColor = jerryBtn.FlatAppearance.BorderColor;
            newJerryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            newJerryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            Random random = new Random();
            int x = random.Next(10, 800);
            int y = random.Next(10, 600);
            newJerryBtn.Location = new Point(x, y);
            newJerryBtn.AutoSize = true;;
            newJerryBtn.MouseMove += jerryBtn_MouseMove;
            this.Controls.Add(newJerryBtn);
        }
    }
}
