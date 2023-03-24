
namespace WindowsFormsApp1
{
    partial class admin_login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_label = new System.Windows.Forms.Label();
            this.admin_login = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.admin_user = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 518);
            this.panel1.TabIndex = 6;
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.BackColor = System.Drawing.Color.White;
            this.admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(183)))), ((int)(((byte)(227)))));
            this.admin_label.Location = new System.Drawing.Point(94, 100);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(123, 39);
            this.admin_label.TabIndex = 10;
            this.admin_label.Text = "Sign In";
            // 
            // admin_login
            // 
            this.admin_login.BackColor = System.Drawing.Color.SkyBlue;
            this.admin_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login.Location = new System.Drawing.Point(101, 310);
            this.admin_login.Margin = new System.Windows.Forms.Padding(2);
            this.admin_login.Name = "admin_login";
            this.admin_login.Size = new System.Drawing.Size(127, 35);
            this.admin_login.TabIndex = 9;
            this.admin_login.Text = "Login";
            this.admin_login.UseVisualStyleBackColor = false;
            this.admin_login.Click += new System.EventHandler(this.admin_login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 231);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 172);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // admin_pass
            // 
            this.admin_pass.BackColor = System.Drawing.Color.White;
            this.admin_pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_pass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.admin_pass.Location = new System.Drawing.Point(89, 245);
            this.admin_pass.Margin = new System.Windows.Forms.Padding(2);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.Size = new System.Drawing.Size(198, 26);
            this.admin_pass.TabIndex = 6;
            this.admin_pass.Text = "Password";
            // 
            // admin_user
            // 
            this.admin_user.BackColor = System.Drawing.Color.White;
            this.admin_user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_user.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.admin_user.Location = new System.Drawing.Point(89, 186);
            this.admin_user.Margin = new System.Windows.Forms.Padding(2);
            this.admin_user.Name = "admin_user";
            this.admin_user.Size = new System.Drawing.Size(198, 26);
            this.admin_user.TabIndex = 5;
            this.admin_user.Text = "UserName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.admin_label);
            this.panel2.Controls.Add(this.admin_login);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.admin_pass);
            this.panel2.Controls.Add(this.admin_user);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 496);
            this.panel2.TabIndex = 11;
            // 
            // admin_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 518);
            this.Controls.Add(this.panel1);
            this.Name = "admin_login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox admin_pass;
        private System.Windows.Forms.TextBox admin_user;
        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Panel panel2;
    }
}