namespace Blackjack
{
    partial class Highscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscores));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backLbl = new System.Windows.Forms.Label();
            this.scoresLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 68);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // backLbl
            // 
            this.backLbl.AutoSize = true;
            this.backLbl.BackColor = System.Drawing.Color.Transparent;
            this.backLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLbl.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.backLbl.ForeColor = System.Drawing.Color.White;
            this.backLbl.Location = new System.Drawing.Point(12, 9);
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(52, 16);
            this.backLbl.TabIndex = 3;
            this.backLbl.Text = "back";
            this.backLbl.Click += new System.EventHandler(this.backLbl_Click);
            this.backLbl.MouseEnter += new System.EventHandler(this.backLbl_MouseEnter);
            this.backLbl.MouseLeave += new System.EventHandler(this.backLbl_MouseLeave);
            // 
            // scoresLbl
            // 
            this.scoresLbl.AutoSize = true;
            this.scoresLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoresLbl.Font = new System.Drawing.Font("Minecraft", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresLbl.ForeColor = System.Drawing.Color.White;
            this.scoresLbl.Location = new System.Drawing.Point(291, 140);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(201, 27);
            this.scoresLbl.TabIndex = 4;
            this.scoresLbl.Text = "Top10Players";
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.backLbl);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Highscores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label backLbl;
        private System.Windows.Forms.Label scoresLbl;
    }
}