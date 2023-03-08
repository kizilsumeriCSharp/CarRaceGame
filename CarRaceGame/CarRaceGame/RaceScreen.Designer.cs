namespace CarRaceGame
{
    partial class RaceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceScreen));
            this.finishLineBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.car1PictureBox = new System.Windows.Forms.PictureBox();
            this.car2PictureBox = new System.Windows.Forms.PictureBox();
            this.car3PictureBox = new System.Windows.Forms.PictureBox();
            this.startRaceBtn = new System.Windows.Forms.Button();
            this.racetimer = new System.Windows.Forms.Timer(this.components);
            this.car1BoostBtn = new System.Windows.Forms.Button();
            this.car2BoostBtn = new System.Windows.Forms.Button();
            this.car3BoostBtn = new System.Windows.Forms.Button();
            this.Car1BoostTimer = new System.Windows.Forms.Timer(this.components);
            this.Car2BoostTimer = new System.Windows.Forms.Timer(this.components);
            this.Car3BoostTimer = new System.Windows.Forms.Timer(this.components);
            this.wayBtn = new System.Windows.Forms.Button();
            this.car1BreakBtn = new System.Windows.Forms.Button();
            this.car2BreakBtn = new System.Windows.Forms.Button();
            this.car3BreakBtn = new System.Windows.Forms.Button();
            this.racestartTimer = new System.Windows.Forms.Timer(this.components);
            this.racestartLbl = new System.Windows.Forms.Label();
            this.car1boostBar = new System.Windows.Forms.ProgressBar();
            this.car2boostBar = new System.Windows.Forms.ProgressBar();
            this.car3boostBar = new System.Windows.Forms.ProgressBar();
            this.namePlateLbl = new System.Windows.Forms.Label();
            this.namePlatePctrbx = new System.Windows.Forms.PictureBox();
            this.car1RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.car2RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.car3RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.visibleBreakBtn = new System.Windows.Forms.Button();
            this.visibleBreakBtn2 = new System.Windows.Forms.Button();
            this.visibleBreakBtn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePlatePctrbx)).BeginInit();
            this.SuspendLayout();
            // 
            // finishLineBtn
            // 
            this.finishLineBtn.BackColor = System.Drawing.Color.Transparent;
            this.finishLineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishLineBtn.BackgroundImage")));
            this.finishLineBtn.FlatAppearance.BorderSize = 0;
            this.finishLineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishLineBtn.Location = new System.Drawing.Point(1029, 88);
            this.finishLineBtn.Name = "finishLineBtn";
            this.finishLineBtn.Size = new System.Drawing.Size(78, 288);
            this.finishLineBtn.TabIndex = 0;
            this.finishLineBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(211, -84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 607);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // car1PictureBox
            // 
            this.car1PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.car1PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car1PictureBox.BackgroundImage")));
            this.car1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("car1PictureBox.Image")));
            this.car1PictureBox.Location = new System.Drawing.Point(74, 109);
            this.car1PictureBox.Name = "car1PictureBox";
            this.car1PictureBox.Size = new System.Drawing.Size(101, 68);
            this.car1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1PictureBox.TabIndex = 1;
            this.car1PictureBox.TabStop = false;
            // 
            // car2PictureBox
            // 
            this.car2PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.car2PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car2PictureBox.BackgroundImage")));
            this.car2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("car2PictureBox.Image")));
            this.car2PictureBox.Location = new System.Drawing.Point(74, 197);
            this.car2PictureBox.Name = "car2PictureBox";
            this.car2PictureBox.Size = new System.Drawing.Size(101, 68);
            this.car2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2PictureBox.TabIndex = 1;
            this.car2PictureBox.TabStop = false;
            // 
            // car3PictureBox
            // 
            this.car3PictureBox.BackColor = System.Drawing.Color.Gray;
            this.car3PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car3PictureBox.BackgroundImage")));
            this.car3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("car3PictureBox.Image")));
            this.car3PictureBox.Location = new System.Drawing.Point(74, 300);
            this.car3PictureBox.Name = "car3PictureBox";
            this.car3PictureBox.Size = new System.Drawing.Size(101, 68);
            this.car3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3PictureBox.TabIndex = 1;
            this.car3PictureBox.TabStop = false;
            // 
            // startRaceBtn
            // 
            this.startRaceBtn.BackColor = System.Drawing.Color.Gold;
            this.startRaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRaceBtn.Font = new System.Drawing.Font("Minecraft", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startRaceBtn.ForeColor = System.Drawing.Color.Indigo;
            this.startRaceBtn.Location = new System.Drawing.Point(8, 412);
            this.startRaceBtn.Name = "startRaceBtn";
            this.startRaceBtn.Size = new System.Drawing.Size(170, 101);
            this.startRaceBtn.TabIndex = 2;
            this.startRaceBtn.Text = "Start\r\nRace";
            this.startRaceBtn.UseVisualStyleBackColor = false;
            this.startRaceBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // racetimer
            // 
            this.racetimer.Interval = 40;
            this.racetimer.Tick += new System.EventHandler(this.racetimer_Tick);
            // 
            // car1BoostBtn
            // 
            this.car1BoostBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.car1BoostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car1BoostBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car1BoostBtn.Location = new System.Drawing.Point(184, 443);
            this.car1BoostBtn.Name = "car1BoostBtn";
            this.car1BoostBtn.Size = new System.Drawing.Size(147, 32);
            this.car1BoostBtn.TabIndex = 5;
            this.car1BoostBtn.Text = "Car1Boost";
            this.car1BoostBtn.UseVisualStyleBackColor = false;
            this.car1BoostBtn.Click += new System.EventHandler(this.button5_Click);
            this.car1BoostBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button5_KeyDown);
            // 
            // car2BoostBtn
            // 
            this.car2BoostBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.car2BoostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car2BoostBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car2BoostBtn.Location = new System.Drawing.Point(337, 443);
            this.car2BoostBtn.Name = "car2BoostBtn";
            this.car2BoostBtn.Size = new System.Drawing.Size(147, 32);
            this.car2BoostBtn.TabIndex = 5;
            this.car2BoostBtn.Text = "Car2Boost";
            this.car2BoostBtn.UseVisualStyleBackColor = false;
            this.car2BoostBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // car3BoostBtn
            // 
            this.car3BoostBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.car3BoostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car3BoostBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car3BoostBtn.Location = new System.Drawing.Point(490, 443);
            this.car3BoostBtn.Name = "car3BoostBtn";
            this.car3BoostBtn.Size = new System.Drawing.Size(147, 32);
            this.car3BoostBtn.TabIndex = 5;
            this.car3BoostBtn.Text = "Car3Boost";
            this.car3BoostBtn.UseVisualStyleBackColor = false;
            this.car3BoostBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // Car1BoostTimer
            // 
            this.Car1BoostTimer.Interval = 20;
            this.Car1BoostTimer.Tick += new System.EventHandler(this.Car1BoostTimer_Tick);
            // 
            // Car2BoostTimer
            // 
            this.Car2BoostTimer.Interval = 20;
            this.Car2BoostTimer.Tick += new System.EventHandler(this.Car2BoostTimer_Tick);
            // 
            // Car3BoostTimer
            // 
            this.Car3BoostTimer.Interval = 20;
            this.Car3BoostTimer.Tick += new System.EventHandler(this.Car3BoostTimer_Tick);
            // 
            // wayBtn
            // 
            this.wayBtn.BackColor = System.Drawing.Color.Transparent;
            this.wayBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wayBtn.BackgroundImage")));
            this.wayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wayBtn.FlatAppearance.BorderSize = 0;
            this.wayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wayBtn.Location = new System.Drawing.Point(-16, -51);
            this.wayBtn.Name = "wayBtn";
            this.wayBtn.Size = new System.Drawing.Size(1253, 498);
            this.wayBtn.TabIndex = 0;
            this.wayBtn.UseVisualStyleBackColor = false;
            this.wayBtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // car1BreakBtn
            // 
            this.car1BreakBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.car1BreakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car1BreakBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car1BreakBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.car1BreakBtn.Location = new System.Drawing.Point(184, 481);
            this.car1BreakBtn.Name = "car1BreakBtn";
            this.car1BreakBtn.Size = new System.Drawing.Size(147, 32);
            this.car1BreakBtn.TabIndex = 5;
            this.car1BreakBtn.Text = "Car1Break";
            this.car1BreakBtn.UseVisualStyleBackColor = false;
            this.car1BreakBtn.Click += new System.EventHandler(this.button8_Click);
            this.car1BreakBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            this.car1BreakBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.car1BreakBtn_MouseUp);
            // 
            // car2BreakBtn
            // 
            this.car2BreakBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.car2BreakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car2BreakBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car2BreakBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.car2BreakBtn.Location = new System.Drawing.Point(337, 481);
            this.car2BreakBtn.Name = "car2BreakBtn";
            this.car2BreakBtn.Size = new System.Drawing.Size(147, 32);
            this.car2BreakBtn.TabIndex = 5;
            this.car2BreakBtn.Text = "Car2Break";
            this.car2BreakBtn.UseVisualStyleBackColor = false;
            this.car2BreakBtn.Click += new System.EventHandler(this.car2BreakBtn_Click);
            this.car2BreakBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.car2BreakBtn_MouseDown);
            this.car2BreakBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.car2BreakBtn_MouseUp);
            // 
            // car3BreakBtn
            // 
            this.car3BreakBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.car3BreakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car3BreakBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.car3BreakBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.car3BreakBtn.Location = new System.Drawing.Point(490, 481);
            this.car3BreakBtn.Name = "car3BreakBtn";
            this.car3BreakBtn.Size = new System.Drawing.Size(147, 32);
            this.car3BreakBtn.TabIndex = 5;
            this.car3BreakBtn.Text = "Car3Break";
            this.car3BreakBtn.UseVisualStyleBackColor = false;
            this.car3BreakBtn.Click += new System.EventHandler(this.car3BreakBtn_Click);
            this.car3BreakBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.car3BreakBtn_MouseDown);
            this.car3BreakBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.car3BreakBtn_MouseUp);
            // 
            // racestartTimer
            // 
            this.racestartTimer.Interval = 1000;
            this.racestartTimer.Tick += new System.EventHandler(this.racestartTimer_Tick);
            // 
            // racestartLbl
            // 
            this.racestartLbl.BackColor = System.Drawing.Color.Red;
            this.racestartLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.racestartLbl.Font = new System.Drawing.Font("Minecraft", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.racestartLbl.Location = new System.Drawing.Point(490, 166);
            this.racestartLbl.Name = "racestartLbl";
            this.racestartLbl.Size = new System.Drawing.Size(172, 129);
            this.racestartLbl.TabIndex = 6;
            this.racestartLbl.Text = "3";
            this.racestartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // car1boostBar
            // 
            this.car1boostBar.Location = new System.Drawing.Point(184, 412);
            this.car1boostBar.Name = "car1boostBar";
            this.car1boostBar.Size = new System.Drawing.Size(147, 25);
            this.car1boostBar.TabIndex = 7;
            // 
            // car2boostBar
            // 
            this.car2boostBar.Location = new System.Drawing.Point(337, 412);
            this.car2boostBar.Name = "car2boostBar";
            this.car2boostBar.Size = new System.Drawing.Size(147, 25);
            this.car2boostBar.TabIndex = 7;
            // 
            // car3boostBar
            // 
            this.car3boostBar.Location = new System.Drawing.Point(490, 412);
            this.car3boostBar.Name = "car3boostBar";
            this.car3boostBar.Size = new System.Drawing.Size(147, 25);
            this.car3boostBar.TabIndex = 7;
            // 
            // namePlateLbl
            // 
            this.namePlateLbl.AutoSize = true;
            this.namePlateLbl.BackColor = System.Drawing.Color.Tan;
            this.namePlateLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namePlateLbl.Font = new System.Drawing.Font("Minecraft", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namePlateLbl.Location = new System.Drawing.Point(716, 443);
            this.namePlateLbl.Name = "namePlateLbl";
            this.namePlateLbl.Size = new System.Drawing.Size(391, 40);
            this.namePlateLbl.TabIndex = 9;
            this.namePlateLbl.Text = "Car Took To Lead\r\n";
            // 
            // namePlatePctrbx
            // 
            this.namePlatePctrbx.Image = ((System.Drawing.Image)(resources.GetObject("namePlatePctrbx.Image")));
            this.namePlatePctrbx.Location = new System.Drawing.Point(643, 412);
            this.namePlatePctrbx.Name = "namePlatePctrbx";
            this.namePlatePctrbx.Size = new System.Drawing.Size(561, 101);
            this.namePlatePctrbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePlatePctrbx.TabIndex = 8;
            this.namePlatePctrbx.TabStop = false;
            // 
            // car1RaceTimer
            // 
            this.car1RaceTimer.Interval = 40;
            this.car1RaceTimer.Tick += new System.EventHandler(this.car1RaceTimer_Tick);
            // 
            // car2RaceTimer
            // 
            this.car2RaceTimer.Interval = 40;
            this.car2RaceTimer.Tick += new System.EventHandler(this.car2RaceTimer_Tick);
            // 
            // car3RaceTimer
            // 
            this.car3RaceTimer.Interval = 40;
            this.car3RaceTimer.Tick += new System.EventHandler(this.car3RaceTimer_Tick);
            // 
            // visibleBreakBtn
            // 
            this.visibleBreakBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.visibleBreakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visibleBreakBtn.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.visibleBreakBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.visibleBreakBtn.Location = new System.Drawing.Point(184, 481);
            this.visibleBreakBtn.Name = "visibleBreakBtn";
            this.visibleBreakBtn.Size = new System.Drawing.Size(147, 32);
            this.visibleBreakBtn.TabIndex = 5;
            this.visibleBreakBtn.Text = "Car1Break";
            this.visibleBreakBtn.UseVisualStyleBackColor = false;
            this.visibleBreakBtn.Click += new System.EventHandler(this.visibleBreakBtn_Click);
            this.visibleBreakBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            // 
            // visibleBreakBtn2
            // 
            this.visibleBreakBtn2.BackColor = System.Drawing.Color.Goldenrod;
            this.visibleBreakBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visibleBreakBtn2.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.visibleBreakBtn2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.visibleBreakBtn2.Location = new System.Drawing.Point(337, 481);
            this.visibleBreakBtn2.Name = "visibleBreakBtn2";
            this.visibleBreakBtn2.Size = new System.Drawing.Size(147, 32);
            this.visibleBreakBtn2.TabIndex = 5;
            this.visibleBreakBtn2.Text = "Car2Break";
            this.visibleBreakBtn2.UseVisualStyleBackColor = false;
            this.visibleBreakBtn2.Click += new System.EventHandler(this.visibleBreakBtn2_Click);
            // 
            // visibleBreakBtn3
            // 
            this.visibleBreakBtn3.BackColor = System.Drawing.Color.Goldenrod;
            this.visibleBreakBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visibleBreakBtn3.Font = new System.Drawing.Font("Minecraft", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.visibleBreakBtn3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.visibleBreakBtn3.Location = new System.Drawing.Point(490, 481);
            this.visibleBreakBtn3.Name = "visibleBreakBtn3";
            this.visibleBreakBtn3.Size = new System.Drawing.Size(147, 32);
            this.visibleBreakBtn3.TabIndex = 5;
            this.visibleBreakBtn3.Text = "Car3Break";
            this.visibleBreakBtn3.UseVisualStyleBackColor = false;
            this.visibleBreakBtn3.Click += new System.EventHandler(this.visibleBreakBtn3_Click);
            // 
            // RaceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1209, 520);
            this.Controls.Add(this.namePlateLbl);
            this.Controls.Add(this.namePlatePctrbx);
            this.Controls.Add(this.car3boostBar);
            this.Controls.Add(this.car2boostBar);
            this.Controls.Add(this.car1boostBar);
            this.Controls.Add(this.racestartLbl);
            this.Controls.Add(this.finishLineBtn);
            this.Controls.Add(this.car3PictureBox);
            this.Controls.Add(this.car2PictureBox);
            this.Controls.Add(this.car1PictureBox);
            this.Controls.Add(this.car3BreakBtn);
            this.Controls.Add(this.car3BoostBtn);
            this.Controls.Add(this.car2BreakBtn);
            this.Controls.Add(this.car2BoostBtn);
            this.Controls.Add(this.car1BreakBtn);
            this.Controls.Add(this.car1BoostBtn);
            this.Controls.Add(this.startRaceBtn);
            this.Controls.Add(this.wayBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.visibleBreakBtn);
            this.Controls.Add(this.visibleBreakBtn2);
            this.Controls.Add(this.visibleBreakBtn3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "RaceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaceScreen";
            this.Load += new System.EventHandler(this.RaceScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaceScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RaceScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.car1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePlatePctrbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button finishLineBtn;
        private Button button2;
        private PictureBox car1PictureBox;
        private PictureBox car2PictureBox;
        private PictureBox car3PictureBox;
        private Button startRaceBtn;
        private System.Windows.Forms.Timer racetimer;
        private Button car1BoostBtn;
        private Button car2BoostBtn;
        private Button car3BoostBtn;
        private System.Windows.Forms.Timer Car1BoostTimer;
        private System.Windows.Forms.Timer Car2BoostTimer;
        private System.Windows.Forms.Timer Car3BoostTimer;
        private Button wayBtn;
        private Button car1BreakBtn;
        private Button car2BreakBtn;
        private Button car3BreakBtn;
        private System.Windows.Forms.Timer racestartTimer;
        private Label racestartLbl;
        private ProgressBar car1boostBar;
        private ProgressBar car2boostBar;
        private ProgressBar car3boostBar;
        private Label namePlateLbl;
        private PictureBox namePlatePctrbx;
        private System.Windows.Forms.Timer car1RaceTimer;
        private System.Windows.Forms.Timer car2RaceTimer;
        private System.Windows.Forms.Timer car3RaceTimer;
        private Button visibleBreakBtn;
        private Button visibleBreakBtn2;
        private Button visibleBreakBtn3;
    }
}