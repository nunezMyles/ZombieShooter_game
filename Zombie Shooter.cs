using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Shooter_Game
{
    public partial class ZombieShooterGame : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver, flagShoot, flagReload;
        string facing = "up";
        int zombieKills, ammoChance;
        int playerHealth = 500;
        int playerSpeed = 1;
        int zombieSpeed = 1;
        int ammoCount = 30;
        int magCount = 30;
        double anglePlayer = 0;

        Point cursor;
        Point playerLookDirection;

        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>(100);

        // Image Cache
        Image ammoPic = Properties.Resources.gunAmmo;
        Image playerImg = Properties.Resources.playerUp;
        Image zombieLeft = Properties.Resources.zombieLeft;
        Image zombieRight = Properties.Resources.zombieRight;
        Image zombieUp = Properties.Resources.zombieUp;
        Image zombieDown = Properties.Resources.zombieDown;

        public ZombieShooterGame()
        {
            InitializeComponent();
            restartGame();
        }

        private void picBoxPlayer_Paint(object sender, PaintEventArgs e)
        {
            if (!gameOver)
            {
                e.Graphics.TranslateTransform(picBoxPlayer.Width / 2, picBoxPlayer.Height / 2);
                e.Graphics.RotateTransform((float)anglePlayer);
                e.Graphics.TranslateTransform(-picBoxPlayer.Width / 2, -picBoxPlayer.Height / 2);
                e.Graphics.DrawImage(playerImg, 0, 0, 40, 40);
                e.Graphics.ResetTransform();
            }
        }

        private void playerTimer_Tick(object sender, EventArgs e)
        {
            picBoxPlayer.Invalidate();

            if (playerHealth > 1) healthBar.Value = playerHealth;

            else
            {
                gameOver = true;
                picBoxPlayer.Image = Properties.Resources.playerDead;
                playerTimer.Stop();
            }

            lblAmmo.Text = "Ammo: " + ammoCount;
            lblMagazine.Text = "Magazine: " + magCount + "/30";
            lblKills.Text = "Kills: " + zombieKills;

            if (magCount == 0 && ammoCount > 0)
            {
                reloadBar.Location = new Point(picBoxPlayer.Left + picBoxPlayer.Width / 2 - reloadBar.Width / 2, picBoxPlayer.Top - 10);
                reloadBar.Visible = true;

                flagReload = true;
                if (reloadBar.Value == reloadBar.Maximum)
                {
                    if (ammoCount < 30)
                    {
                        magCount = ammoCount;
                        ammoCount = 0;
                    }
                    else
                    {
                        ammoCount -= 30;
                        magCount = 30;
                    }

                    reloadBar.Visible = false;
                    reloadBar.Location = new Point(0, 0);
                    flagReload = false;
                    reloadBar.Value = 0;
                }
            }

            if (goLeft == true && picBoxPlayer.Left > 0) 
                picBoxPlayer.Left -= playerSpeed;

            if (goRight == true && picBoxPlayer.Left + picBoxPlayer.Width < picBoxMain.ClientSize.Width)
                picBoxPlayer.Left += playerSpeed;

            if (goUp == true && picBoxPlayer.Top > panelStats.Height)
                picBoxPlayer.Top -= playerSpeed;

            if (goDown == true && picBoxPlayer.Top + picBoxPlayer.Height < picBoxMain.ClientSize.Height)
                picBoxPlayer.Top += playerSpeed;

            foreach (Control i in picBoxMain.Controls)
            {
                if (i is PictureBox && (string)i.Tag == "ammo")
                {
                    if (picBoxPlayer.Bounds.IntersectsWith(i.Bounds))
                    {
                        picBoxMain.Controls.Remove(i);
                        ((PictureBox)i).Dispose();
                        ammoCount += 5;
                    }
                }

                if (i is PictureBox && (string)i.Tag == "zombie")
                {
                    if (picBoxPlayer.Bounds.IntersectsWith(i.Bounds)) playerHealth--;
                }

                foreach (Control k in picBoxMain.Controls)
                {
                    if (k is PictureBox && (string)k.Tag == "bullet" && i is PictureBox && (string)i.Tag == "zombie")
                    {
                        if (i.Bounds.IntersectsWith(k.Bounds))
                        {
                            zombieKills++;
                            ammoChance = randNum.Next(1, 3); // 50% chance

                            picBoxMain.Controls.Remove(k);
                            ((PictureBox)k).Dispose();

                            picBoxMain.Controls.Remove(i);
                            ((PictureBox)i).Dispose();
                            zombiesList.Remove((PictureBox)i);

                            if (ammoChance == 1)
                                dropAmmo(k.Location);

                            makeZombies();
                        }
                    }
                }
            }
        } 

        private void zombieTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control y in picBoxMain.Controls)
            {
                if (y is PictureBox && (string)y.Tag == "zombie")
                {
                    if (y.Left > picBoxPlayer.Left + (picBoxPlayer.Width / 2))
                    {
                        y.Left -= zombieSpeed;
                        ((PictureBox)y).Image = zombieLeft;
                    }

                    if (y.Left < picBoxPlayer.Left - (picBoxPlayer.Width / 2))
                    {
                        y.Left += zombieSpeed;
                        ((PictureBox)y).Image = zombieRight;
                    }

                    if (y.Top > picBoxPlayer.Top + (picBoxPlayer.Height / 2))
                    {
                        y.Top -= zombieSpeed;
                        ((PictureBox)y).Image = zombieUp;
                    }

                    if (y.Top < picBoxPlayer.Top - (picBoxPlayer.Height / 2))
                    {
                        y.Top += zombieSpeed;
                        ((PictureBox)y).Image = zombieDown;
                    }
                    if (y.Top >= picBoxPlayer.Top - (picBoxPlayer.Height / 2) && 
                        y.Top <= picBoxPlayer.Top + (picBoxPlayer.Height / 2) &&
                        y.Left >= picBoxPlayer.Left - (picBoxPlayer.Width / 2) &&
                        y.Left <= picBoxPlayer.Left + (picBoxPlayer.Width / 2))
                        ((PictureBox)y).Image = zombieDown;
                }
            }
        }

        private void fireRateTimer_Tick(object sender, EventArgs e)
        {
            if (flagShoot == true && magCount > 0 && gameOver == false)
            {
                shootBullet(facing);
                magCount--;
            }
            if (flagReload == true)
                reloadBar.PerformStep();
        }

        private void ZombieShooterGame_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Enter && gameOver == true)
                restartGame();

            if (gameOver == true)
                return;

            switch (e.KeyCode)
            {
                case Keys.A:
                    goLeft = true;
                    break;
                case Keys.D:
                    goRight = true;
                    break;
                case Keys.W:
                    goUp = true;
                    break;
                case Keys.S:
                    goDown = true;
                    break;
                case Keys.Space:
                    flagShoot = true;
                    break;
                default:
                    break;
            }
        }

        private void ZombieShooterGame_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    goLeft = false;
                    break;
                case Keys.D:
                    goRight = false;
                    break;
                case Keys.W:
                    goUp = false;
                    break;
                case Keys.S:
                    goDown = false;
                    break;
                case Keys.Space:
                    flagShoot = false;
                    break;
                default:
                    break;
            }
        }

        private void picBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            cursor = e.Location;

            if (gameOver == true)
                return;

            playerLookDirection.X = cursor.X - (picBoxPlayer.Left + picBoxPlayer.Width / 2);
            playerLookDirection.Y = cursor.Y - (picBoxPlayer.Top + picBoxPlayer.Height / 2);
            anglePlayer = (Math.Atan2(playerLookDirection.Y, playerLookDirection.X) / Math.PI * 180) + 90;

            if (anglePlayer > -11.25 && anglePlayer < 11.25) facing = "0 deg";

            if (anglePlayer > 11.25 && anglePlayer < 33.75) facing = "22.5 deg";

            if (anglePlayer > 33.75 && anglePlayer < 56.25) facing = "45 deg";

            if (anglePlayer > 56.25 && anglePlayer < 78.75) facing = "67.5 deg";

            if (anglePlayer > 78.75 && anglePlayer < 101.25) facing = "90 deg";

            if (anglePlayer > 101.25 && anglePlayer < 123.75) facing = "112.5 deg";

            if (anglePlayer > 123.75 && anglePlayer < 146.25) facing = "135 deg";

            if (anglePlayer > 146.25 && anglePlayer < 168.75) facing = "157.5 deg";

            if (anglePlayer > 168.75 && anglePlayer < 192.25) facing = "180 deg";

            if (anglePlayer > 191.25 && anglePlayer < 213.75) facing = "202.5 deg";

            if (anglePlayer > 213.75 && anglePlayer < 236.25) facing = "225 deg";

            if (anglePlayer > 236.25 && anglePlayer < 258.75) facing = "247.5 deg";

            if (anglePlayer > 258.75 || anglePlayer < -78.75) facing = "270 deg";

            if (anglePlayer > -78.75 && anglePlayer < -56.25) facing = "292.5 deg";

            if (anglePlayer > -56.25 && anglePlayer < -33.75) facing = "315 deg";

            if (anglePlayer > -33.75 && anglePlayer < -11.25) facing = "337.5 deg";
        }

        private void picBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            flagShoot = true;
        }

        private void picBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            flagShoot = false;
        }

        public void shootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();

            shootBullet.direction = direction;
            shootBullet.bulletLeft = picBoxPlayer.Left + picBoxPlayer.Width / 2;
            shootBullet.bulletTop = picBoxPlayer.Top + picBoxPlayer.Height / 2;

            shootBullet.makeBullet(this, picBoxMain);
        }

        private void makeZombies()
        {
            TransparentPictureBox picBoxZombie = new TransparentPictureBox();

            picBoxZombie.Size = new Size(40, 40);
            picBoxZombie.Tag = "zombie";
            picBoxZombie.Image = zombieDown;
            picBoxZombie.BackColor = Color.Transparent;
            picBoxZombie.Left = randNum.Next(0, picBoxMain.Width);
            picBoxZombie.Top = randNum.Next(0, picBoxMain.Height);
            picBoxZombie.Parent = picBoxMain;
            picBoxZombie.SizeMode = PictureBoxSizeMode.StretchImage;

            zombiesList.Add(picBoxZombie);
            picBoxMain.Controls.Add(picBoxZombie);

            picBoxPlayer.BringToFront();
        }

        private void dropAmmo(Point location)
        {
            PictureBox picBoxAmmo = new PictureBox();

            picBoxAmmo.Size = new Size(30, 30);
            picBoxAmmo.Image = ammoPic;
            picBoxAmmo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAmmo.Location = location;
            picBoxAmmo.Tag = "ammo";
            picBoxAmmo.Parent = picBoxMain;

            picBoxMain.Controls.Add(picBoxAmmo);

            picBoxAmmo.BringToFront();
            picBoxPlayer.BringToFront();
        }

        // Game Initializer
        private void restartGame() 
        {
            picBoxPlayer.Image = null;
            picBoxPlayer.Parent = picBoxMain;
            reloadBar.Parent = picBoxMain;

            this.DoubleBuffered = true;

            foreach (PictureBox j in zombiesList)
            {
                picBoxMain.Controls.Remove(j);
            }
            zombiesList.Clear();

            for (int k = 0; k < 3; k++) makeZombies();

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 500;
            zombieKills = 0;
            ammoCount = 30;

            playerTimer.Start();
        }
    }
}
