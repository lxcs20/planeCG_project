namespace Plane_Shooter
{
    partial class Break
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Break));
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_agian = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soundShooting = new System.Windows.Forms.TrackBar();
            this.soundGame = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.soundShooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundGame)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.DarkRed;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(15, 399);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(45, 40);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            this.btn_home.MouseHover += new System.EventHandler(this.btn_home_MouseHover);
            // 
            // btn_agian
            // 
            this.btn_agian.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_agian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agian.BackgroundImage")));
            this.btn_agian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agian.FlatAppearance.BorderSize = 0;
            this.btn_agian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agian.Location = new System.Drawing.Point(191, 399);
            this.btn_agian.Name = "btn_agian";
            this.btn_agian.Size = new System.Drawing.Size(45, 40);
            this.btn_agian.TabIndex = 1;
            this.btn_agian.UseVisualStyleBackColor = false;
            this.btn_agian.Click += new System.EventHandler(this.btn_agian_Click);
            this.btn_agian.MouseHover += new System.EventHandler(this.btn_agian_MouseHover);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Teal;
            this.btn_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_continue.BackgroundImage")));
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Location = new System.Drawing.Point(393, 399);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(45, 40);
            this.btn_continue.TabIndex = 2;
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click_1);
            this.btn_continue.MouseHover += new System.EventHandler(this.btn_continue_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(378, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(378, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "100";
            // 
            // soundShooting
            // 
            this.soundShooting.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.soundShooting.AutoSize = false;
            this.soundShooting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.soundShooting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.soundShooting.Location = new System.Drawing.Point(86, 204);
            this.soundShooting.Maximum = 100;
            this.soundShooting.Name = "soundShooting";
            this.soundShooting.Size = new System.Drawing.Size(298, 25);
            this.soundShooting.TabIndex = 14;
            this.soundShooting.TickStyle = System.Windows.Forms.TickStyle.None;
            this.soundShooting.Value = 100;
            this.soundShooting.Scroll += new System.EventHandler(this.soundShooting_Scroll);
            // 
            // soundGame
            // 
            this.soundGame.AutoSize = false;
            this.soundGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.soundGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.soundGame.Location = new System.Drawing.Point(86, 258);
            this.soundGame.Maximum = 100;
            this.soundGame.Name = "soundGame";
            this.soundGame.Size = new System.Drawing.Size(298, 25);
            this.soundGame.TabIndex = 13;
            this.soundGame.TickStyle = System.Windows.Forms.TickStyle.None;
            this.soundGame.Value = 100;
            this.soundGame.Scroll += new System.EventHandler(this.soundGame_Scroll);
            // 
            // Break
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundShooting);
            this.Controls.Add(this.soundGame);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_agian);
            this.Controls.Add(this.btn_home);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(466, 460);
            this.MinimumSize = new System.Drawing.Size(460, 460);
            this.Name = "Break";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break";
            ((System.ComponentModel.ISupportInitialize)(this.soundShooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_agian;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar soundShooting;
        private System.Windows.Forms.TrackBar soundGame;
    }
}