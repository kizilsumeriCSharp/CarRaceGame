namespace CarRaceGame
{
    partial class WinnerForm
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
            this.winnerLbl = new System.Windows.Forms.Label();
            this.slideText = new System.Windows.Forms.Timer(this.components);
            this.spawnBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winnerLbl
            // 
            this.winnerLbl.AutoSize = true;
            this.winnerLbl.Font = new System.Drawing.Font("Minecraft", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.winnerLbl.Location = new System.Drawing.Point(-587, 34);
            this.winnerLbl.Name = "winnerLbl";
            this.winnerLbl.Size = new System.Drawing.Size(612, 67);
            this.winnerLbl.TabIndex = 25;
            this.winnerLbl.Text = "CAR 1 IS WINNER";
            // 
            // slideText
            // 
            this.slideText.Interval = 75;
            this.slideText.Tick += new System.EventHandler(this.slideText_Tick);
            // 
            // spawnBtn
            // 
            this.spawnBtn.BackColor = System.Drawing.Color.Transparent;
            this.spawnBtn.FlatAppearance.BorderSize = 0;
            this.spawnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spawnBtn.Location = new System.Drawing.Point(1094, 12);
            this.spawnBtn.Name = "spawnBtn";
            this.spawnBtn.Size = new System.Drawing.Size(21, 113);
            this.spawnBtn.TabIndex = 26;
            this.spawnBtn.Text = "button1";
            this.spawnBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 113);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(554, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(616, 137);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spawnBtn);
            this.Controls.Add(this.winnerLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerForm";
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label winnerLbl;
        private System.Windows.Forms.Timer slideText;
        private Button spawnBtn;
        private Button button1;
        private Button button2;
    }
}