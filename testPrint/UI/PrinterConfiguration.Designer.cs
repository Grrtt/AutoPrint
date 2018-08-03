namespace AutoPrint.UI
{
    partial class PrinterConfiguration
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
            this.txtbx_LabelName = new System.Windows.Forms.TextBox();
            this.lbl_LabelName = new System.Windows.Forms.Label();
            this.grpbx_LabelPrinter = new System.Windows.Forms.GroupBox();
            this.grpbx_BarcodePrinter = new System.Windows.Forms.GroupBox();
            this.lbl_BarcodeName = new System.Windows.Forms.Label();
            this.txtbx_BarcodeName = new System.Windows.Forms.TextBox();
            this.btn_SaveConfiguration = new System.Windows.Forms.Button();
            this.checkbx_ListingAfterBarcode = new System.Windows.Forms.CheckBox();
            this.grpbx_LabelPrinter.SuspendLayout();
            this.grpbx_BarcodePrinter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_LabelName
            // 
            this.txtbx_LabelName.Location = new System.Drawing.Point(63, 23);
            this.txtbx_LabelName.Name = "txtbx_LabelName";
            this.txtbx_LabelName.Size = new System.Drawing.Size(99, 26);
            this.txtbx_LabelName.TabIndex = 2;
            // 
            // lbl_LabelName
            // 
            this.lbl_LabelName.AutoSize = true;
            this.lbl_LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LabelName.Location = new System.Drawing.Point(9, 29);
            this.lbl_LabelName.Name = "lbl_LabelName";
            this.lbl_LabelName.Size = new System.Drawing.Size(48, 16);
            this.lbl_LabelName.TabIndex = 3;
            this.lbl_LabelName.Text = "Name:";
            // 
            // grpbx_LabelPrinter
            // 
            this.grpbx_LabelPrinter.Controls.Add(this.lbl_LabelName);
            this.grpbx_LabelPrinter.Controls.Add(this.txtbx_LabelName);
            this.grpbx_LabelPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_LabelPrinter.Location = new System.Drawing.Point(12, 12);
            this.grpbx_LabelPrinter.Name = "grpbx_LabelPrinter";
            this.grpbx_LabelPrinter.Size = new System.Drawing.Size(191, 60);
            this.grpbx_LabelPrinter.TabIndex = 4;
            this.grpbx_LabelPrinter.TabStop = false;
            this.grpbx_LabelPrinter.Text = "Label";
            // 
            // grpbx_BarcodePrinter
            // 
            this.grpbx_BarcodePrinter.Controls.Add(this.checkbx_ListingAfterBarcode);
            this.grpbx_BarcodePrinter.Controls.Add(this.lbl_BarcodeName);
            this.grpbx_BarcodePrinter.Controls.Add(this.txtbx_BarcodeName);
            this.grpbx_BarcodePrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_BarcodePrinter.Location = new System.Drawing.Point(12, 78);
            this.grpbx_BarcodePrinter.Name = "grpbx_BarcodePrinter";
            this.grpbx_BarcodePrinter.Size = new System.Drawing.Size(191, 83);
            this.grpbx_BarcodePrinter.TabIndex = 5;
            this.grpbx_BarcodePrinter.TabStop = false;
            this.grpbx_BarcodePrinter.Text = "Barcode";
            // 
            // lbl_BarcodeName
            // 
            this.lbl_BarcodeName.AutoSize = true;
            this.lbl_BarcodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BarcodeName.Location = new System.Drawing.Point(9, 31);
            this.lbl_BarcodeName.Name = "lbl_BarcodeName";
            this.lbl_BarcodeName.Size = new System.Drawing.Size(48, 16);
            this.lbl_BarcodeName.TabIndex = 3;
            this.lbl_BarcodeName.Text = "Name:";
            // 
            // txtbx_BarcodeName
            // 
            this.txtbx_BarcodeName.Location = new System.Drawing.Point(63, 25);
            this.txtbx_BarcodeName.Name = "txtbx_BarcodeName";
            this.txtbx_BarcodeName.Size = new System.Drawing.Size(99, 26);
            this.txtbx_BarcodeName.TabIndex = 2;
            // 
            // btn_SaveConfiguration
            // 
            this.btn_SaveConfiguration.Location = new System.Drawing.Point(117, 167);
            this.btn_SaveConfiguration.Name = "btn_SaveConfiguration";
            this.btn_SaveConfiguration.Size = new System.Drawing.Size(86, 23);
            this.btn_SaveConfiguration.TabIndex = 6;
            this.btn_SaveConfiguration.Text = "Save &&  Close";
            this.btn_SaveConfiguration.UseVisualStyleBackColor = true;
            this.btn_SaveConfiguration.Click += new System.EventHandler(this.btn_SaveConfiguration_Click);
            // 
            // checkbx_ListingAfterBarcode
            // 
            this.checkbx_ListingAfterBarcode.AutoSize = true;
            this.checkbx_ListingAfterBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbx_ListingAfterBarcode.Location = new System.Drawing.Point(12, 57);
            this.checkbx_ListingAfterBarcode.Name = "checkbx_ListingAfterBarcode";
            this.checkbx_ListingAfterBarcode.Size = new System.Drawing.Size(149, 17);
            this.checkbx_ListingAfterBarcode.TabIndex = 4;
            this.checkbx_ListingAfterBarcode.Text = "Print listing label after CXZ";
            this.checkbx_ListingAfterBarcode.UseVisualStyleBackColor = true;
            this.checkbx_ListingAfterBarcode.CheckedChanged += new System.EventHandler(this.checkbx_ListingAfterBarcode_CheckedChanged);
            // 
            // PrinterConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 204);
            this.Controls.Add(this.btn_SaveConfiguration);
            this.Controls.Add(this.grpbx_BarcodePrinter);
            this.Controls.Add(this.grpbx_LabelPrinter);
            this.Name = "PrinterConfiguration";
            this.Text = "Printer Configuration";
            this.grpbx_LabelPrinter.ResumeLayout(false);
            this.grpbx_LabelPrinter.PerformLayout();
            this.grpbx_BarcodePrinter.ResumeLayout(false);
            this.grpbx_BarcodePrinter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_LabelName;
        private System.Windows.Forms.Label lbl_LabelName;
        private System.Windows.Forms.GroupBox grpbx_LabelPrinter;
        private System.Windows.Forms.GroupBox grpbx_BarcodePrinter;
        private System.Windows.Forms.Label lbl_BarcodeName;
        private System.Windows.Forms.TextBox txtbx_BarcodeName;
        private System.Windows.Forms.Button btn_SaveConfiguration;
        private System.Windows.Forms.CheckBox checkbx_ListingAfterBarcode;
    }
}