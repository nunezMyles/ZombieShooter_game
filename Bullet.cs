using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Zombie_Shooter_Game
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 6;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void makeBullet(Form form, PictureBox picBoxParent)
        {    
            bullet.BackColor = Color.Gold;
            bullet.BorderStyle = BorderStyle.FixedSingle;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            
            bullet.BringToFront();
            
            picBoxParent.Controls.Add(bullet);

            bullet.Parent = picBoxParent;

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(bulletTimerEvent);
            bulletTimer.Start();
        }

        private void bulletTimerEvent(object sender, EventArgs e)
        {
            switch (direction)
            {
                case "270 deg":
                    bullet.Left -= speed;
                    break;

                case "90 deg":
                    bullet.Left += speed;
                    break;

                case "0 deg":
                    bullet.Top -= speed;
                    break;

                case "180 deg":
                    bullet.Top += speed;
                    break;

                case "315 deg":
                    bullet.Top -= speed;
                    bullet.Left -= speed;
                    break;

                case "45 deg":
                    bullet.Top -= speed;
                    bullet.Left += speed;
                    break;

                case "225 deg":
                    bullet.Top += speed;
                    bullet.Left -= speed;
                    break;

                case "135 deg":
                    bullet.Top += speed;
                    bullet.Left += speed;
                    break;

                case "22.5 deg":
                    bullet.Top -= speed;
                    bullet.Left += speed;
                    bullet.Top -= speed;
                    break;

                case "67.5 deg":
                    bullet.Left += speed;
                    bullet.Top -= speed;
                    bullet.Left += speed / 2;
                    break;

                case "112.5 deg":
                    bullet.Left += speed;
                    bullet.Top += speed;
                    bullet.Left += speed / 2;
                    break;

                case "157.5 deg":
                    bullet.Top += speed;
                    bullet.Left += speed;
                    bullet.Top += speed / 2;
                    break;

                case "202.5 deg":
                    bullet.Top += speed;
                    bullet.Left -= speed;
                    bullet.Top += speed / 2;
                    break;

                case "247.5 deg":
                    bullet.Left -= speed;
                    bullet.Top += speed;
                    bullet.Left -= speed / 2;
                    break;

                case "292.5 deg":
                    bullet.Left -= speed;
                    bullet.Top -= speed;
                    bullet.Left -= speed / 2;
                    break;

                case "337.5 deg":
                    bullet.Top -= speed;
                    bullet.Left -= speed;
                    bullet.Top -= speed / 2;
                    break;

                default:
                    break;
            }

            if (bullet.Left < 10 || bullet.Left > 810 || bullet.Top < 10 || bullet.Top > 450)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }

        }
    }
}
