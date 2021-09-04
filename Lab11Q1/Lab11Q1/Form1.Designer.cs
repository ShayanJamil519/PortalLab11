
namespace Lab11Q1
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
            this.buttonStd = new System.Windows.Forms.Button();
            this.buttonTeach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStd
            // 
            this.buttonStd.BackColor = System.Drawing.Color.Pink;
            this.buttonStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStd.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStd.ForeColor = System.Drawing.Color.Brown;
            this.buttonStd.Location = new System.Drawing.Point(152, 283);
            this.buttonStd.Name = "buttonStd";
            this.buttonStd.Size = new System.Drawing.Size(211, 82);
            this.buttonStd.TabIndex = 0;
            this.buttonStd.Text = "Student";
            this.buttonStd.UseVisualStyleBackColor = false;
            this.buttonStd.Click += new System.EventHandler(this.buttonStd_Click);
            // 
            // buttonTeach
            // 
            this.buttonTeach.BackColor = System.Drawing.Color.Pink;
            this.buttonTeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeach.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeach.ForeColor = System.Drawing.Color.Brown;
            this.buttonTeach.Location = new System.Drawing.Point(596, 293);
            this.buttonTeach.Name = "buttonTeach";
            this.buttonTeach.Size = new System.Drawing.Size(211, 82);
            this.buttonTeach.TabIndex = 0;
            this.buttonTeach.Text = "Teacher";
            this.buttonTeach.UseVisualStyleBackColor = false;
            this.buttonTeach.Click += new System.EventHandler(this.buttonTeach_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Education Portal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab11Q1.Properties.Resources.imageback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTeach);
            this.Controls.Add(this.buttonStd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStd;
        private System.Windows.Forms.Button buttonTeach;
        private System.Windows.Forms.Label label1;
    }
}

