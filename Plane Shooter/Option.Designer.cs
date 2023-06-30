namespace Plane_Shooter
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.btn_select1 = new System.Windows.Forms.Button();
            this.btn_select2 = new System.Windows.Forms.Button();
            this.btn_select3 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_select1
            // 
            this.btn_select1.BackColor = System.Drawing.Color.Turquoise;
            this.btn_select1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select1.ForeColor = System.Drawing.Color.Purple;
            this.btn_select1.Location = new System.Drawing.Point(145, 490);
            this.btn_select1.Name = "btn_select1";
            this.btn_select1.Size = new System.Drawing.Size(75, 29);
            this.btn_select1.TabIndex = 0;
            this.btn_select1.Text = "Select";
            this.btn_select1.UseVisualStyleBackColor = false;
            this.btn_select1.Click += new System.EventHandler(this.btn_select1_Click);
            this.btn_select1.MouseHover += new System.EventHandler(this.btn_select1_MouseHover);
            // 
            // btn_select2
            // 
            this.btn_select2.BackColor = System.Drawing.Color.Turquoise;
            this.btn_select2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select2.ForeColor = System.Drawing.Color.Purple;
            this.btn_select2.Location = new System.Drawing.Point(461, 490);
            this.btn_select2.Name = "btn_select2";
            this.btn_select2.Size = new System.Drawing.Size(75, 29);
            this.btn_select2.TabIndex = 1;
            this.btn_select2.Text = "Select";
            this.btn_select2.UseVisualStyleBackColor = false;
            this.btn_select2.Click += new System.EventHandler(this.btn_select2_Click);
            this.btn_select2.MouseHover += new System.EventHandler(this.btn_select2_MouseHover);
            // 
            // btn_select3
            // 
            this.btn_select3.BackColor = System.Drawing.Color.Turquoise;
            this.btn_select3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_select3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select3.ForeColor = System.Drawing.Color.Purple;
            this.btn_select3.Location = new System.Drawing.Point(776, 490);
            this.btn_select3.Name = "btn_select3";
            this.btn_select3.Size = new System.Drawing.Size(75, 29);
            this.btn_select3.TabIndex = 2;
            this.btn_select3.Text = "Select";
            this.btn_select3.UseVisualStyleBackColor = false;
            this.btn_select3.Click += new System.EventHandler(this.btn_select3_Click);
            this.btn_select3.MouseHover += new System.EventHandler(this.btn_select3_MouseHover);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkRed;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.Location = new System.Drawing.Point(953, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(45, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseHover += new System.EventHandler(this.btn_back_MouseHover);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_select3);
            this.Controls.Add(this.btn_select2);
            this.Controls.Add(this.btn_select1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_select2;
        private System.Windows.Forms.Button btn_select3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_select1;
    }
}