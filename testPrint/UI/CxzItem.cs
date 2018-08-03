using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrint.UI
{
    class CxzItem
    {
        private System.Windows.Forms.Panel pnl_Cxz;
        private System.Windows.Forms.LinkLabel lnklbl_CxzNumber;
        private System.Windows.Forms.PictureBox picbx_CxzPic;
        private System.Windows.Forms.LinkLabel lnklbl_CxzType;
        private System.Windows.Forms.Label lbl_CxzSerials;

        public CxzItem(string[] serials = null)
        {
            if(serials == null)
            {
                serials = serials ?? new string[0];
            }else
            {
                serials = new string[1] { "--- No Serials ---" };
            }
            
            // 
            // pnl_Cxz
            // 
            this.pnl_Cxz.Controls.Add(this.lbl_CxzSerials);
            this.pnl_Cxz.Controls.Add(this.lnklbl_CxzType);
            this.pnl_Cxz.Controls.Add(this.picbx_CxzPic);
            this.pnl_Cxz.Controls.Add(this.lnklbl_CxzNumber);
            this.pnl_Cxz.Location = new System.Drawing.Point(4, 4);
            this.pnl_Cxz.Name = "pnl_Cxz";
            this.pnl_Cxz.Size = new System.Drawing.Size(336, 80);
            this.pnl_Cxz.TabIndex = 0;
            // 
            // lbl_CxzSerials
            // 
            this.lbl_CxzSerials.AutoSize = true;
            this.lbl_CxzSerials.Location = new System.Drawing.Point(78, 28);
            this.lbl_CxzSerials.Name = "lbl_CxzSerials";
            this.lbl_CxzSerials.Size = new System.Drawing.Size(55, 13);
            this.lbl_CxzSerials.TabIndex = 3;
            this.lbl_CxzSerials.Text = "CxzSerials";
            // 
            // lnklbl_CxzType
            // 
            this.lnklbl_CxzType.AutoSize = true;
            this.lnklbl_CxzType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_CxzType.Location = new System.Drawing.Point(78, 4);
            this.lnklbl_CxzType.Name = "lnklbl_CxzType";
            this.lnklbl_CxzType.Size = new System.Drawing.Size(69, 20);
            this.lnklbl_CxzType.TabIndex = 2;
            this.lnklbl_CxzType.TabStop = true;
            this.lnklbl_CxzType.Text = "CxzType";
            // 
            // picbx_CxzPic
            // 
            this.picbx_CxzPic.Location = new System.Drawing.Point(3, 20);
            this.picbx_CxzPic.Name = "picbx_CxzPic";
            this.picbx_CxzPic.Size = new System.Drawing.Size(69, 57);
            this.picbx_CxzPic.TabIndex = 1;
            this.picbx_CxzPic.TabStop = false;
            // 
            // lnklbl_CxzNumber
            // 
            this.lnklbl_CxzNumber.AutoSize = true;
            this.lnklbl_CxzNumber.Location = new System.Drawing.Point(4, 3);
            this.lnklbl_CxzNumber.Name = "lnklbl_CxzNumber";
            this.lnklbl_CxzNumber.Size = new System.Drawing.Size(67, 13);
            this.lnklbl_CxzNumber.TabIndex = 0;
            this.lnklbl_CxzNumber.TabStop = true;
            this.lnklbl_CxzNumber.Text = "CXZ-123456";
        }
        
    }
}
