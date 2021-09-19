
namespace BT_NangCao_TranMinhCanh
{
    partial class AddFeedForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbToaSoan = new System.Windows.Forms.ComboBox();
            this.txtChuyenMuc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại  xổ số";
            // 
            // cbbToaSoan
            // 
            this.cbbToaSoan.FormattingEnabled = true;
            this.cbbToaSoan.Location = new System.Drawing.Point(152, 22);
            this.cbbToaSoan.Name = "cbbToaSoan";
            this.cbbToaSoan.Size = new System.Drawing.Size(161, 28);
            this.cbbToaSoan.TabIndex = 1;
            // 
            // txtChuyenMuc
            // 
            this.txtChuyenMuc.Location = new System.Drawing.Point(152, 60);
            this.txtChuyenMuc.Name = "txtChuyenMuc";
            this.txtChuyenMuc.Size = new System.Drawing.Size(161, 27);
            this.txtChuyenMuc.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(152, 93);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(336, 27);
            this.txtLink.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Loại xổ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "RSS link";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 137);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 180);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtChuyenMuc);
            this.Controls.Add(this.cbbToaSoan);
            this.Controls.Add(this.label1);
            this.Name = "AddFeedForm";
            this.Text = "AddFeedForm";
            this.Load += new System.EventHandler(this.AddFeedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbToaSoan;
        private System.Windows.Forms.TextBox txtChuyenMuc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}