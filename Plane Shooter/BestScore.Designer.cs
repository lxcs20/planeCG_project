namespace Plane_Shooter
{
    partial class BestScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestScore));
            this.btn_back = new System.Windows.Forms.Button();
            this.best_level1 = new System.Windows.Forms.Label();
            this.best_level2 = new System.Windows.Forms.Label();
            this.best_level3 = new System.Windows.Forms.Label();
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
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseHover += new System.EventHandler(this.btn_back_MouseHover);
            // 
            // best_level1
            // 
            this.best_level1.AutoSize = true;
            this.best_level1.BackColor = System.Drawing.Color.Transparent;
            this.best_level1.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_level1.ForeColor = System.Drawing.Color.White;
            this.best_level1.Location = new System.Drawing.Point(66, 255);
            this.best_level1.Name = "best_level1";
            this.best_level1.Size = new System.Drawing.Size(32, 18);
            this.best_level1.TabIndex = 5;
            this.best_level1.Text = "1111";
            // 
            // best_level2
            // 
            this.best_level2.AutoSize = true;
            this.best_level2.BackColor = System.Drawing.Color.Transparent;
            this.best_level2.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_level2.ForeColor = System.Drawing.Color.White;
            this.best_level2.Location = new System.Drawing.Point(208, 255);
            this.best_level2.Name = "best_level2";
            this.best_level2.Size = new System.Drawing.Size(32, 18);
            this.best_level2.TabIndex = 6;
            this.best_level2.Text = "1111";
            // 
            // best_level3
            // 
            this.best_level3.AutoSize = true;
            this.best_level3.BackColor = System.Drawing.Color.Transparent;
            this.best_level3.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_level3.ForeColor = System.Drawing.Color.White;
            this.best_level3.Location = new System.Drawing.Point(350, 255);
            this.best_level3.Name = "best_level3";
            this.best_level3.Size = new System.Drawing.Size(32, 18);
            this.best_level3.TabIndex = 7;
            this.best_level3.Text = "1111";
            // 
            // BestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 423);
            this.Controls.Add(this.best_level3);
            this.Controls.Add(this.best_level2);
            this.Controls.Add(this.best_level1);
            this.Controls.Add(this.btn_back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(448, 423);
            this.MinimumSize = new System.Drawing.Size(448, 423);
            this.Name = "BestScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BestScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label best_level1;
        private System.Windows.Forms.Label best_level2;
        private System.Windows.Forms.Label best_level3;
    }
}