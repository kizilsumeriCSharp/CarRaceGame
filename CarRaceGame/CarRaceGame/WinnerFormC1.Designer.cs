namespace CarRaceGame
{
    partial class WinnerFormC1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thrdrndwnrlbl = new System.Windows.Forms.Label();
            this.scnroundwnrlbl = new System.Windows.Forms.Label();
            this.frstroundwnrlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(466, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 54);
            this.label3.TabIndex = 20;
            this.label3.Text = "ThirdRound\r\nWinner\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 54);
            this.label2.TabIndex = 22;
            this.label2.Text = "SecondRound\r\nWinner\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 54);
            this.label4.TabIndex = 24;
            this.label4.Text = "FirstRound\r\nWinner\r\n";
            // 
            // thrdrndwnrlbl
            // 
            this.thrdrndwnrlbl.AutoSize = true;
            this.thrdrndwnrlbl.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thrdrndwnrlbl.Location = new System.Drawing.Point(466, 318);
            this.thrdrndwnrlbl.Name = "thrdrndwnrlbl";
            this.thrdrndwnrlbl.Size = new System.Drawing.Size(8, 12);
            this.thrdrndwnrlbl.TabIndex = 19;
            this.thrdrndwnrlbl.Text = ",";
            // 
            // scnroundwnrlbl
            // 
            this.scnroundwnrlbl.AutoSize = true;
            this.scnroundwnrlbl.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scnroundwnrlbl.Location = new System.Drawing.Point(237, 318);
            this.scnroundwnrlbl.Name = "scnroundwnrlbl";
            this.scnroundwnrlbl.Size = new System.Drawing.Size(8, 12);
            this.scnroundwnrlbl.TabIndex = 21;
            this.scnroundwnrlbl.Text = ",";
            // 
            // frstroundwnrlbl
            // 
            this.frstroundwnrlbl.AutoSize = true;
            this.frstroundwnrlbl.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frstroundwnrlbl.Location = new System.Drawing.Point(37, 318);
            this.frstroundwnrlbl.Name = "frstroundwnrlbl";
            this.frstroundwnrlbl.Size = new System.Drawing.Size(8, 12);
            this.frstroundwnrlbl.TabIndex = 23;
            this.frstroundwnrlbl.Text = ",";
            // 
            // WinnerFormC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(689, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thrdrndwnrlbl);
            this.Controls.Add(this.scnroundwnrlbl);
            this.Controls.Add(this.frstroundwnrlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinnerFormC1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnerFormC1";
            this.Load += new System.EventHandler(this.WinnerFormC1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label4;
        public Label thrdrndwnrlbl;
        public Label scnroundwnrlbl;
        public Label frstroundwnrlbl;
    }
}