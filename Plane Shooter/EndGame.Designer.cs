namespace Plane_Shooter
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.btn_agian = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agian
            // 
            this.btn_agian.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_agian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agian.BackgroundImage")));
            this.btn_agian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agian.FlatAppearance.BorderSize = 0;
            this.btn_agian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agian.Location = new System.Drawing.Point(334, 523);
            this.btn_agian.Name = "btn_agian";
            this.btn_agian.Size = new System.Drawing.Size(45, 40);
            this.btn_agian.TabIndex = 3;
            this.btn_agian.UseVisualStyleBackColor = false;
            this.btn_agian.Click += new System.EventHandler(this.btn_agian_Click);
            this.btn_agian.MouseHover += new System.EventHandler(this.btn_agian_MouseHover);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.DarkRed;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(34, 523);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(45, 40);
            this.btn_home.TabIndex = 2;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            this.btn_home.MouseHover += new System.EventHandler(this.btn_home_MouseHover);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 595);
            this.Controls.Add(this.btn_agian);
            this.Controls.Add(this.btn_home);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(423, 595);
            this.MinimumSize = new System.Drawing.Size(423, 595);
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agian;
        private System.Windows.Forms.Button btn_home;
    }
}