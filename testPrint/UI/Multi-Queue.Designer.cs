namespace AutoPrint.UI
{
    partial class frm_multiQueue
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
            this.grpbx_QueueList = new System.Windows.Forms.GroupBox();
            this.pnl_CxzList = new System.Windows.Forms.Panel();
            this.txtbx_CxzEntry = new System.Windows.Forms.TextBox();
            this.btn_Queue = new System.Windows.Forms.Button();
            this.chckbx_report = new System.Windows.Forms.CheckBox();
            this.chckbx_consolidate = new System.Windows.Forms.CheckBox();
            this.grpbx_QueueList.SuspendLayout();
            this.pnl_CxzList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_QueueList
            // 
            this.grpbx_QueueList.Controls.Add(this.pnl_CxzList);
            this.grpbx_QueueList.Controls.Add(this.txtbx_CxzEntry);
            this.grpbx_QueueList.Location = new System.Drawing.Point(13, 13);
            this.grpbx_QueueList.Name = "grpbx_QueueList";
            this.grpbx_QueueList.Size = new System.Drawing.Size(356, 375);
            this.grpbx_QueueList.TabIndex = 0;
            this.grpbx_QueueList.TabStop = false;
            this.grpbx_QueueList.Text = "CXZs for Queue:";
            // 
            // pnl_CxzList
            // 
            this.pnl_CxzList.Location = new System.Drawing.Point(7, 47);
            this.pnl_CxzList.Name = "pnl_CxzList";
            this.pnl_CxzList.Size = new System.Drawing.Size(343, 322);
            this.pnl_CxzList.TabIndex = 1;
            // 
            // txtbx_CxzEntry
            // 
            this.txtbx_CxzEntry.Location = new System.Drawing.Point(7, 20);
            this.txtbx_CxzEntry.Name = "txtbx_CxzEntry";
            this.txtbx_CxzEntry.Size = new System.Drawing.Size(100, 20);
            this.txtbx_CxzEntry.TabIndex = 0;
            // 
            // btn_Queue
            // 
            this.btn_Queue.Location = new System.Drawing.Point(20, 394);
            this.btn_Queue.Name = "btn_Queue";
            this.btn_Queue.Size = new System.Drawing.Size(100, 23);
            this.btn_Queue.TabIndex = 1;
            this.btn_Queue.Text = "Queue Items";
            this.btn_Queue.UseVisualStyleBackColor = true;
            // 
            // chckbx_report
            // 
            this.chckbx_report.AutoSize = true;
            this.chckbx_report.Location = new System.Drawing.Point(127, 398);
            this.chckbx_report.Name = "chckbx_report";
            this.chckbx_report.Size = new System.Drawing.Size(82, 17);
            this.chckbx_report.TabIndex = 2;
            this.chckbx_report.Text = "Print Report";
            this.chckbx_report.UseVisualStyleBackColor = true;
            // 
            // chckbx_consolidate
            // 
            this.chckbx_consolidate.AutoSize = true;
            this.chckbx_consolidate.Location = new System.Drawing.Point(216, 399);
            this.chckbx_consolidate.Name = "chckbx_consolidate";
            this.chckbx_consolidate.Size = new System.Drawing.Size(119, 17);
            this.chckbx_consolidate.TabIndex = 3;
            this.chckbx_consolidate.Text = "Consolidate Listings";
            this.chckbx_consolidate.UseVisualStyleBackColor = true;
            // 
            // frm_multiQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 429);
            this.Controls.Add(this.chckbx_consolidate);
            this.Controls.Add(this.chckbx_report);
            this.Controls.Add(this.btn_Queue);
            this.Controls.Add(this.grpbx_QueueList);
            this.Name = "frm_multiQueue";
            this.Text = "Multi-Queue";
            this.grpbx_QueueList.ResumeLayout(false);
            this.grpbx_QueueList.PerformLayout();
            this.pnl_CxzList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_QueueList;
        private System.Windows.Forms.TextBox txtbx_CxzEntry;
        private System.Windows.Forms.Button btn_Queue;
        private System.Windows.Forms.CheckBox chckbx_report;
        private System.Windows.Forms.Panel pnl_CxzList;
        private System.Windows.Forms.CheckBox chckbx_consolidate;
    }
}