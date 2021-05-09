
namespace PBL3
{
    partial class MenuMainSV
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
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.butTT = new System.Windows.Forms.Button();
            this.butListSV = new System.Windows.Forms.Button();
            this.butListP = new System.Windows.Forms.Button();
            this.butThoat = new System.Windows.Forms.Button();
            this.txtNameTK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản :";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(225, 22);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.ReadOnly = true;
            this.txtMaTK.Size = new System.Drawing.Size(136, 22);
            this.txtMaTK.TabIndex = 1;
            // 
            // butTT
            // 
            this.butTT.Location = new System.Drawing.Point(175, 111);
            this.butTT.Name = "butTT";
            this.butTT.Size = new System.Drawing.Size(145, 52);
            this.butTT.TabIndex = 2;
            this.butTT.Text = "Thông tin SV";
            this.butTT.UseVisualStyleBackColor = true;
            // 
            // butListSV
            // 
            this.butListSV.Location = new System.Drawing.Point(175, 179);
            this.butListSV.Name = "butListSV";
            this.butListSV.Size = new System.Drawing.Size(145, 52);
            this.butListSV.TabIndex = 3;
            this.butListSV.Text = "Danh Sách SV";
            this.butListSV.UseVisualStyleBackColor = true;
            // 
            // butListP
            // 
            this.butListP.Location = new System.Drawing.Point(175, 247);
            this.butListP.Name = "butListP";
            this.butListP.Size = new System.Drawing.Size(145, 52);
            this.butListP.TabIndex = 4;
            this.butListP.Text = "Danh sách phòng";
            this.butListP.UseVisualStyleBackColor = true;
            // 
            // butThoat
            // 
            this.butThoat.Location = new System.Drawing.Point(411, 321);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(75, 22);
            this.butThoat.TabIndex = 5;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = true;
            // 
            // txtNameTK
            // 
            this.txtNameTK.Location = new System.Drawing.Point(150, 60);
            this.txtNameTK.Name = "txtNameTK";
            this.txtNameTK.ReadOnly = true;
            this.txtNameTK.Size = new System.Drawing.Size(193, 22);
            this.txtNameTK.TabIndex = 6;
            // 
            // MenuMainSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 353);
            this.Controls.Add(this.txtNameTK);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butListP);
            this.Controls.Add(this.butListSV);
            this.Controls.Add(this.butTT);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.label1);
            this.Name = "MenuMainSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Button butTT;
        private System.Windows.Forms.Button butListSV;
        private System.Windows.Forms.Button butListP;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.TextBox txtNameTK;
    }
}