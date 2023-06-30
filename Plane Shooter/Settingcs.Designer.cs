namespace Plane_Shooter
{
    partial class Settingcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settingcs));
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soundShooting = new System.Windows.Forms.TrackBar();
            this.soundGame = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.soundShooting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundGame)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkRed;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.Location = new System.Drawing.Point(12, 371);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(45, 40);
            this.btn_back.TabIndex = 3;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseHover += new System.EventHandler(this.btn_back_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(370, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(370, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "100";
            // 
            // soundShooting
            // 
            this.soundShooting.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.soundShooting.AutoSize = false;
            this.soundShooting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(25)))), ((int)(((byte)(59)))));
            this.soundShooting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.soundShooting.Location = new System.Drawing.Point(78, 60);
            this.soundShooting.Maximum = 100;
            this.soundShooting.Name = "soundShooting";
            this.soundShooting.Size = new System.Drawing.Size(298, 25);
            this.soundShooting.TabIndex = 10;
            this.soundShooting.TickStyle = System.Windows.Forms.TickStyle.None;
            this.soundShooting.Value = 100;
            this.soundShooting.Scroll += new System.EventHandler(this.soundShooting_Scroll);
            // 
            // soundGame
            // 
            this.soundGame.AutoSize = false;
            this.soundGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(25)))), ((int)(((byte)(59)))));
            this.soundGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.soundGame.Location = new System.Drawing.Point(78, 109);
            this.soundGame.Maximum = 100;
            this.soundGame.Name = "soundGame";
            this.soundGame.Size = new System.Drawing.Size(298, 25);
            this.soundGame.TabIndex = 9;
            this.soundGame.TickStyle = System.Windows.Forms.TickStyle.None;
            this.soundGame.Value = 100;
            this.soundGame.Scroll += new System.EventHandler(this.soundGame_Scroll);
            // 
            // Settingcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundShooting);
            this.Controls.Add(this.soundGame);
            this.Controls.Add(this.btn_back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(448, 423);
            this.MinimumSize = new System.Drawing.Size(448, 423);
            this.Name = "Settingcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settingcs";
            ((System.ComponentModel.ISupportInitialize)(this.soundShooting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar soundShooting;
        private System.Windows.Forms.TrackBar soundGame;
    }
}