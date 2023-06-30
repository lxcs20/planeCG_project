namespace Plane_Shooter
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_gameOver = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBreakgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // lb_gameOver
            // 
            this.lb_gameOver.AutoSize = true;
            this.lb_gameOver.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gameOver.ForeColor = System.Drawing.Color.White;
            this.lb_gameOver.Location = new System.Drawing.Point(29, 372);
            this.lb_gameOver.Name = "lb_gameOver";
            this.lb_gameOver.Size = new System.Drawing.Size(631, 103);
            this.lb_gameOver.TabIndex = 3;
            this.lb_gameOver.Text = "GAME OVER";
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.ForeColor = System.Drawing.Color.White;
            this.lb_score.Location = new System.Drawing.Point(77, 9);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(62, 20);
            this.lb_score.TabIndex = 4;
            this.lb_score.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(240, 638);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBreakgame
            // 
            this.btnBreakgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBreakgame.FlatAppearance.BorderSize = 0;
            this.btnBreakgame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBreakgame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBreakgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakgame.Image = ((System.Drawing.Image)(resources.GetObject("btnBreakgame.Image")));
            this.btnBreakgame.Location = new System.Drawing.Point(642, 9);
            this.btnBreakgame.Name = "btnBreakgame";
            this.btnBreakgame.Size = new System.Drawing.Size(46, 37);
            this.btnBreakgame.TabIndex = 6;
            this.btnBreakgame.UseVisualStyleBackColor = true;
            this.btnBreakgame.Click += new System.EventHandler(this.btnBreakgame_Click);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 850);
            this.Controls.Add(this.btnBreakgame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.lb_gameOver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 850);
            this.MinimumSize = new System.Drawing.Size(700, 850);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Play_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_gameOver;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBreakgame;
    }
}