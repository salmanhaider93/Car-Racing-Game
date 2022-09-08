namespace RacingCar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Line1 = new System.Windows.Forms.PictureBox();
            this.Line2 = new System.Windows.Forms.PictureBox();
            this.Line3 = new System.Windows.Forms.PictureBox();
            this.Line4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ememy2 = new System.Windows.Forms.PictureBox();
            this.ememy3 = new System.Windows.Forms.PictureBox();
            this.ememy1 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.coins_score = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.over = new System.Windows.Forms.Label();
            this.newgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.Location = new System.Drawing.Point(185, 0);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(10, 106);
            this.Line1.TabIndex = 0;
            this.Line1.TabStop = false;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.White;
            this.Line2.Location = new System.Drawing.Point(185, 122);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(10, 106);
            this.Line2.TabIndex = 1;
            this.Line2.TabStop = false;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.White;
            this.Line3.Location = new System.Drawing.Point(185, 245);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(10, 106);
            this.Line3.TabIndex = 2;
            this.Line3.TabStop = false;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.White;
            this.Line4.Location = new System.Drawing.Point(185, 368);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(10, 105);
            this.Line4.TabIndex = 3;
            this.Line4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 462);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(374, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 450);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ememy2
            // 
            this.ememy2.Image = ((System.Drawing.Image)(resources.GetObject("ememy2.Image")));
            this.ememy2.Location = new System.Drawing.Point(144, 82);
            this.ememy2.Name = "ememy2";
            this.ememy2.Size = new System.Drawing.Size(26, 65);
            this.ememy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ememy2.TabIndex = 6;
            this.ememy2.TabStop = false;
            this.ememy2.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // ememy3
            // 
            this.ememy3.Image = ((System.Drawing.Image)(resources.GetObject("ememy3.Image")));
            this.ememy3.Location = new System.Drawing.Point(333, 190);
            this.ememy3.Name = "ememy3";
            this.ememy3.Size = new System.Drawing.Size(35, 65);
            this.ememy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ememy3.TabIndex = 8;
            this.ememy3.TabStop = false;
            // 
            // ememy1
            // 
            this.ememy1.Image = ((System.Drawing.Image)(resources.GetObject("ememy1.Image")));
            this.ememy1.Location = new System.Drawing.Point(25, 245);
            this.ememy1.Name = "ememy1";
            this.ememy1.Size = new System.Drawing.Size(32, 54);
            this.ememy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ememy1.TabIndex = 9;
            this.ememy1.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(62, 172);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(27, 23);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 10;
            this.Coin1.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.Location = new System.Drawing.Point(268, 82);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(27, 24);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 11;
            this.Coin3.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(259, 264);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(24, 24);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 12;
            this.Coin2.TabStop = false;
            // 
            // coins_score
            // 
            this.coins_score.AutoSize = true;
            this.coins_score.Location = new System.Drawing.Point(12, 0);
            this.coins_score.Name = "coins_score";
            this.coins_score.Size = new System.Drawing.Size(45, 13);
            this.coins_score.TabIndex = 14;
            this.coins_score.Text = "Coins=0";
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(127, 305);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(35, 56);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 17;
            this.Player.TabStop = false;
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(121, 211);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(162, 31);
            this.over.TabIndex = 18;
            this.over.Text = "Game Over";
            // 
            // newgame
            // 
            this.newgame.Location = new System.Drawing.Point(144, 245);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(109, 22);
            this.newgame.TabIndex = 19;
            this.newgame.Text = "New Game";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.over);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.coins_score);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.ememy1);
            this.Controls.Add(this.ememy3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.ememy2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Line1;
        private System.Windows.Forms.PictureBox Line2;
        private System.Windows.Forms.PictureBox Line3;
        private System.Windows.Forms.PictureBox Line4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ememy2;
        private System.Windows.Forms.PictureBox ememy3;
        private System.Windows.Forms.PictureBox ememy1;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.Label coins_score;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Button newgame;
    }
}

