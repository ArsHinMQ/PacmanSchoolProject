namespace PacMan
{
    partial class DashboardForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHaert = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.pacmanDataSet1 = new PacMan.pacmanDataSet();
            this.playerTableAdapter1 = new PacMan.pacmanDataSetTableAdapters.playerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "img/pacman-right.png";
            this.pictureBox1.Location = new System.Drawing.Point(395, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "img/enemy-red.png";
            this.pictureBox2.Location = new System.Drawing.Point(12, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "img/enemy-green.png";
            this.pictureBox3.Location = new System.Drawing.Point(54, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageLocation = "img/enemy-purple.png";
            this.pictureBox4.Location = new System.Drawing.Point(97, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageLocation = "img/heart.png";
            this.pictureBox5.Location = new System.Drawing.Point(395, 258);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Arshia", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(326, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 65);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "عنوان";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("B Arshia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(186, 111);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(71, 44);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "زمان: 0";
            // 
            // lblHaert
            // 
            this.lblHaert.AutoSize = true;
            this.lblHaert.Font = new System.Drawing.Font("B Arshia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHaert.ForeColor = System.Drawing.Color.Crimson;
            this.lblHaert.Location = new System.Drawing.Point(168, 153);
            this.lblHaert.Name = "lblHaert";
            this.lblHaert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHaert.Size = new System.Drawing.Size(107, 43);
            this.lblHaert.TabIndex = 7;
            this.lblHaert.Text = "قلب ها: 3";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Font = new System.Drawing.Font("B Arshia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlay.Location = new System.Drawing.Point(157, 252);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(128, 41);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "شروع مجدد";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("B Arshia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCoins.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoins.Location = new System.Drawing.Point(121, 196);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCoins.Size = new System.Drawing.Size(200, 43);
            this.lblCoins.TabIndex = 9;
            this.lblCoins.Text = "سکه های باقی مانده: 0";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("B Arshia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Green;
            this.lblHighScore.Location = new System.Drawing.Point(12, 9);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHighScore.Size = new System.Drawing.Size(128, 44);
            this.lblHighScore.TabIndex = 10;
            this.lblHighScore.Text = "بهترین زمان: 0";
            // 
            // pacmanDataSet1
            // 
            this.pacmanDataSet1.DataSetName = "pacmanDataSet";
            this.pacmanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter1
            // 
            this.playerTableAdapter1.ClearBeforeFill = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(442, 351);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblHaert);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("B Arshia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "DashboardForm";
            this.Text = "Pac Man - Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHaert;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblHighScore;
        private pacmanDataSet pacmanDataSet1;
        private pacmanDataSetTableAdapters.playerTableAdapter playerTableAdapter1;
    }
}