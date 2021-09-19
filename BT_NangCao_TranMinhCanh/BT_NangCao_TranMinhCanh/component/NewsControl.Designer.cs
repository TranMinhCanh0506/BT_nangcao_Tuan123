
namespace BT_NangCao_TranMinhCanh.component
{
    partial class NewsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbPublisherDate = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(14, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(51, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescription.AutoEllipsis = true;
            this.lbDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDescription.Location = new System.Drawing.Point(14, 31);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(470, 46);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "label2";
            // 
            // lbPublisherDate
            // 
            this.lbPublisherDate.AutoSize = true;
            this.lbPublisherDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPublisherDate.Location = new System.Drawing.Point(15, 77);
            this.lbPublisherDate.Name = "lbPublisherDate";
            this.lbPublisherDate.Size = new System.Drawing.Size(50, 20);
            this.lbPublisherDate.TabIndex = 2;
            this.lbPublisherDate.Text = "label3";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(396, 77);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(88, 20);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.TabStop = true;
            this.lblDetail.Text = "Xem chi tiết";
     
            // 
            // NewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lbPublisherDate);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbTitle);
            this.Name = "NewsControl";
            this.Size = new System.Drawing.Size(501, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbPublisherDate;
        private System.Windows.Forms.LinkLabel lblDetail;
    }
}
