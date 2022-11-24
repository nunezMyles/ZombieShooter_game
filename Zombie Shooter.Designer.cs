
namespace Zombie_Shooter_Game
{
    partial class ZombieShooterGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.fireRateTimer = new System.Windows.Forms.Timer(this.components);
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblMagazine = new System.Windows.Forms.Label();
            this.armorBar = new System.Windows.Forms.ProgressBar();
            this.reloadBar = new System.Windows.Forms.ProgressBar();
            this.panelStats = new System.Windows.Forms.Panel();
            this.zombieTimer = new System.Windows.Forms.Timer(this.components);
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new Zombie_Shooter_Game.TransparentPictureBox();
            this.panelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.DimGray;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.White;
            this.lblAmmo.Location = new System.Drawing.Point(12, 9);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(91, 25);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "Ammo: 0";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.BackColor = System.Drawing.Color.DimGray;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.ForeColor = System.Drawing.Color.White;
            this.lblKills.Location = new System.Drawing.Point(557, 9);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(70, 25);
            this.lblKills.TabIndex = 1;
            this.lblKills.Text = "Kills: 0";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.DimGray;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(947, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(79, 25);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health: ";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(1032, 12);
            this.healthBar.Maximum = 500;
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(179, 25);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 500;
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Interval = 1;
            this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
            // 
            // fireRateTimer
            // 
            this.fireRateTimer.Enabled = true;
            this.fireRateTimer.Interval = 150;
            this.fireRateTimer.Tick += new System.EventHandler(this.fireRateTimer_Tick);
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.BackColor = System.Drawing.Color.DimGray;
            this.lblArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmor.ForeColor = System.Drawing.Color.White;
            this.lblArmor.Location = new System.Drawing.Point(679, 9);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(76, 25);
            this.lblArmor.TabIndex = 5;
            this.lblArmor.Text = "Armor: ";
            // 
            // lblMagazine
            // 
            this.lblMagazine.AutoSize = true;
            this.lblMagazine.BackColor = System.Drawing.Color.DimGray;
            this.lblMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazine.ForeColor = System.Drawing.Color.White;
            this.lblMagazine.Location = new System.Drawing.Point(152, 9);
            this.lblMagazine.Name = "lblMagazine";
            this.lblMagazine.Size = new System.Drawing.Size(159, 25);
            this.lblMagazine.TabIndex = 6;
            this.lblMagazine.Text = "Magazine: 30/30";
            // 
            // armorBar
            // 
            this.armorBar.BackColor = System.Drawing.Color.DimGray;
            this.armorBar.Location = new System.Drawing.Point(762, 11);
            this.armorBar.Maximum = 500;
            this.armorBar.Name = "armorBar";
            this.armorBar.Size = new System.Drawing.Size(179, 25);
            this.armorBar.TabIndex = 7;
            this.armorBar.Value = 500;
            // 
            // reloadBar
            // 
            this.reloadBar.BackColor = System.Drawing.Color.DimGray;
            this.reloadBar.Location = new System.Drawing.Point(0, 53);
            this.reloadBar.MarqueeAnimationSpeed = 5;
            this.reloadBar.Maximum = 10;
            this.reloadBar.Name = "reloadBar";
            this.reloadBar.Size = new System.Drawing.Size(103, 10);
            this.reloadBar.Step = 1;
            this.reloadBar.TabIndex = 8;
            this.reloadBar.Visible = false;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.DimGray;
            this.panelStats.Controls.Add(this.lblKills);
            this.panelStats.Controls.Add(this.lblMagazine);
            this.panelStats.Controls.Add(this.lblAmmo);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1223, 47);
            this.panelStats.TabIndex = 9;
            // 
            // zombieTimer
            // 
            this.zombieTimer.Enabled = true;
            this.zombieTimer.Interval = 70;
            this.zombieTimer.Tick += new System.EventHandler(this.zombieTimer_Tick);
            // 
            // picBoxMain
            // 
            this.picBoxMain.BackColor = System.Drawing.Color.LightGray;
            this.picBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMain.Location = new System.Drawing.Point(0, 53);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(1223, 502);
            this.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMain.TabIndex = 10;
            this.picBoxMain.TabStop = false;
            this.picBoxMain.Tag = "";
            this.picBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseDown);
            this.picBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseMove);
            this.picBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseUp);
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPlayer.Image = global::Zombie_Shooter_Game.Properties.Resources.playerUp;
            this.picBoxPlayer.Location = new System.Drawing.Point(593, 283);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(60, 60);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 11;
            this.picBoxPlayer.TabStop = false;
            this.picBoxPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxPlayer_Paint);
            // 
            // ZombieShooterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1223, 649);
            this.Controls.Add(this.reloadBar);
            this.Controls.Add(this.picBoxPlayer);
            this.Controls.Add(this.armorBar);
            this.Controls.Add(this.lblArmor);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.picBoxMain);
            this.Name = "ZombieShooterGame";
            this.Text = "Zombie Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZombieShooterGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ZombieShooterGame_KeyUp);
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.Timer fireRateTimer;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblMagazine;
        private System.Windows.Forms.ProgressBar armorBar;
        private System.Windows.Forms.ProgressBar reloadBar;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Timer zombieTimer;
        private System.Windows.Forms.PictureBox picBoxMain;
        private TransparentPictureBox picBoxPlayer;
    }
}

