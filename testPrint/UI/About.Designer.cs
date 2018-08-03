namespace AutoPrint.UI
{
    partial class About
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
            this.lbl_About_Title = new System.Windows.Forms.Label();
            this.lbl_About_Author = new System.Windows.Forms.Label();
            this.lbl_Auto_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_About_Title
            // 
            this.lbl_About_Title.AutoSize = true;
            this.lbl_About_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_About_Title.Location = new System.Drawing.Point(40, 9);
            this.lbl_About_Title.Name = "lbl_About_Title";
            this.lbl_About_Title.Size = new System.Drawing.Size(84, 20);
            this.lbl_About_Title.TabIndex = 0;
            this.lbl_About_Title.Text = "AutoPrint";
            // 
            // lbl_About_Author
            // 
            this.lbl_About_Author.AutoSize = true;
            this.lbl_About_Author.Location = new System.Drawing.Point(21, 29);
            this.lbl_About_Author.Name = "lbl_About_Author";
            this.lbl_About_Author.Size = new System.Drawing.Size(125, 13);
            this.lbl_About_Author.TabIndex = 1;
            this.lbl_About_Author.Text = "Author: Garrett Shepherd";
            // 
            // lbl_Auto_Description
            // 
            this.lbl_Auto_Description.AutoSize = true;
            this.lbl_Auto_Description.Location = new System.Drawing.Point(19, 42);
            this.lbl_Auto_Description.Name = "lbl_Auto_Description";
            this.lbl_Auto_Description.Size = new System.Drawing.Size(128, 13);
            this.lbl_Auto_Description.TabIndex = 2;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 66);
            this.Controls.Add(this.lbl_Auto_Description);
            this.Controls.Add(this.lbl_About_Author);
            this.Controls.Add(this.lbl_About_Title);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_About_Title;
        private System.Windows.Forms.Label lbl_About_Author;
        private System.Windows.Forms.Label lbl_Auto_Description;
    }
}