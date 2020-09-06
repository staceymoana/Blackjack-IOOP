namespace Blackjack
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.playerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.highscoresLbl = new System.Windows.Forms.Label();
            this.quitLbl = new System.Windows.Forms.Label();
            this.startLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(13, 214);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(205, 20);
            this.playerName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraft", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "enter your name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Blackjack.Properties.Resources.BLACKJACK;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructionsLbl.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.ForeColor = System.Drawing.Color.Transparent;
            this.instructionsLbl.Location = new System.Drawing.Point(46, 66);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(142, 21);
            this.instructionsLbl.TabIndex = 45;
            this.instructionsLbl.Text = "instructions";
            this.instructionsLbl.Click += new System.EventHandler(this.instructionsLbl_Click);
            this.instructionsLbl.MouseEnter += new System.EventHandler(this.instructionsLbl_MouseEnter);
            this.instructionsLbl.MouseLeave += new System.EventHandler(this.instructionsLbl_MouseLeave);
            // 
            // highscoresLbl
            // 
            this.highscoresLbl.AutoSize = true;
            this.highscoresLbl.BackColor = System.Drawing.Color.Transparent;
            this.highscoresLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscoresLbl.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresLbl.ForeColor = System.Drawing.Color.Transparent;
            this.highscoresLbl.Location = new System.Drawing.Point(51, 109);
            this.highscoresLbl.Name = "highscoresLbl";
            this.highscoresLbl.Size = new System.Drawing.Size(130, 21);
            this.highscoresLbl.TabIndex = 46;
            this.highscoresLbl.Text = "highscores";
            this.highscoresLbl.Click += new System.EventHandler(this.highscoresLbl_Click);
            this.highscoresLbl.MouseEnter += new System.EventHandler(this.highscoresLbl_MouseEnter);
            this.highscoresLbl.MouseLeave += new System.EventHandler(this.highscoresLbl_MouseLeave);
            // 
            // quitLbl
            // 
            this.quitLbl.AutoSize = true;
            this.quitLbl.BackColor = System.Drawing.Color.Transparent;
            this.quitLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitLbl.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitLbl.ForeColor = System.Drawing.Color.Transparent;
            this.quitLbl.Location = new System.Drawing.Point(87, 150);
            this.quitLbl.Name = "quitLbl";
            this.quitLbl.Size = new System.Drawing.Size(50, 21);
            this.quitLbl.TabIndex = 47;
            this.quitLbl.Text = "quit";
            this.quitLbl.Click += new System.EventHandler(this.quitLbl_Click);
            this.quitLbl.MouseEnter += new System.EventHandler(this.quitLbl_MouseEnter);
            this.quitLbl.MouseLeave += new System.EventHandler(this.quitLbl_MouseLeave);
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.BackColor = System.Drawing.Color.Transparent;
            this.startLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLbl.Font = new System.Drawing.Font("Minecraft", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLbl.ForeColor = System.Drawing.Color.White;
            this.startLbl.Location = new System.Drawing.Point(70, 248);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(88, 29);
            this.startLbl.TabIndex = 48;
            this.startLbl.Text = "start";
            this.startLbl.Click += new System.EventHandler(this.startLbl_Click);
            this.startLbl.MouseEnter += new System.EventHandler(this.startLbl_MouseEnter);
            this.startLbl.MouseLeave += new System.EventHandler(this.startLbl_MouseLeave);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(229, 289);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.quitLbl);
            this.Controls.Add(this.highscoresLbl);
            this.Controls.Add(this.instructionsLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.Label highscoresLbl;
        private System.Windows.Forms.Label quitLbl;
        private System.Windows.Forms.Label startLbl;
    }
}