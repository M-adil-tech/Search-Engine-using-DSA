
namespace WindowsFormsApp1
{
    partial class Most_Clicked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Most_Clicked));
            this.back = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_search = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(352, 155);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(123, 35);
            this.back.TabIndex = 11;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(163, 155);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(113, 35);
            this.show.TabIndex = 2;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(183)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(115, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most Searched Keyword";
            // 
            // m_search
            // 
            this.m_search.BackColor = System.Drawing.Color.White;
            this.m_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_search.Location = new System.Drawing.Point(12, 196);
            this.m_search.Name = "m_search";
            this.m_search.Size = new System.Drawing.Size(388, 284);
            this.m_search.TabIndex = 0;
            this.m_search.Text = "";
            this.m_search.TextChanged += new System.EventHandler(this.m_search_TextChanged);
            // 
            // Most_Clicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.m_search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show);
            this.DoubleBuffered = true;
            this.Name = "Most_Clicked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Most_Clicked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RichTextBox m_search;
    }
}