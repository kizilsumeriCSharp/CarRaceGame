namespace CarRaceGame
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashscreentimer = new System.Windows.Forms.Timer(this.components);
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.loadingBarCarGif = new System.Windows.Forms.PictureBox();
            this.playBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cargif = new System.Windows.Forms.Timer(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.cntrlsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBarCarGif)).BeginInit();
            this.SuspendLayout();
            // 
            // splashscreentimer
            // 
            this.splashscreentimer.Enabled = true;
            this.splashscreentimer.Interval = 75;
            this.splashscreentimer.Tick += new System.EventHandler(this.splashscreentimer_Tick);
            // 
            // loadingBar
            // 
            this.loadingBar.ForeColor = System.Drawing.Color.Yellow;
            this.loadingBar.Location = new System.Drawing.Point(9, 74);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(284, 54);
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingBar.TabIndex = 12;
            // 
            // loadingBarCarGif
            // 
            this.loadingBarCarGif.BackColor = System.Drawing.Color.Transparent;
            this.loadingBarCarGif.Image = ((System.Drawing.Image)(resources.GetObject("loadingBarCarGif.Image")));
            this.loadingBarCarGif.Location = new System.Drawing.Point(9, 25);
            this.loadingBarCarGif.Name = "loadingBarCarGif";
            this.loadingBarCarGif.Size = new System.Drawing.Size(171, 63);
            this.loadingBarCarGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingBarCarGif.TabIndex = 13;
            this.loadingBarCarGif.TabStop = false;
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.White;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Minecraft", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playBtn.Location = new System.Drawing.Point(82, 73);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(249, 63);
            this.playBtn.TabIndex = 11;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.button1_Click);
            this.playBtn.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.playBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.White;
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Minecraft", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutBtn.Location = new System.Drawing.Point(129, 190);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(162, 42);
            this.aboutBtn.TabIndex = 11;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.button2_Click);
            this.aboutBtn.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.aboutBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "V0.2 BETA";
            // 
            // cargif
            // 
            this.cargif.Interval = 180;
            this.cargif.Tick += new System.EventHandler(this.cargif_Tick);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Minecraft", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(146, 238);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(126, 25);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit Game";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            this.exitBtn.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.exitBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // cntrlsBtn
            // 
            this.cntrlsBtn.BackColor = System.Drawing.Color.White;
            this.cntrlsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlsBtn.FlatAppearance.BorderSize = 0;
            this.cntrlsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cntrlsBtn.Font = new System.Drawing.Font("Minecraft", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cntrlsBtn.Location = new System.Drawing.Point(103, 142);
            this.cntrlsBtn.Name = "cntrlsBtn";
            this.cntrlsBtn.Size = new System.Drawing.Size(208, 42);
            this.cntrlsBtn.TabIndex = 11;
            this.cntrlsBtn.Text = "Controls";
            this.cntrlsBtn.UseVisualStyleBackColor = false;
            this.cntrlsBtn.Click += new System.EventHandler(this.button4_Click);
            this.cntrlsBtn.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.cntrlsBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 11);
            this.label2.TabIndex = 14;
            this.label2.Text = "made by m3rcy";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.cntrlsBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.loadingBarCarGif);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingBarCarGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer splashscreentimer;
        private ProgressBar loadingBar;
        private PictureBox loadingBarCarGif;
        private Button playBtn;
        private Button aboutBtn;
        private Label label1;
        private System.Windows.Forms.Timer cargif;
        private Button exitBtn;
        private Button cntrlsBtn;
        private Label label2;
    }
}