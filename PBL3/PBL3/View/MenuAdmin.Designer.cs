﻿
namespace PBL3
{
    partial class MenuAdmin
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
            this.txtNameTK = new System.Windows.Forms.TextBox();
            this.butThoat = new System.Windows.Forms.Button();
            this.butListP = new System.Windows.Forms.Button();
            this.butListSV = new System.Windows.Forms.Button();
            this.butTT = new System.Windows.Forms.Button();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameTK
            // 
            this.txtNameTK.Location = new System.Drawing.Point(134, 49);
            this.txtNameTK.Name = "txtNameTK";
            this.txtNameTK.ReadOnly = true;
            this.txtNameTK.Size = new System.Drawing.Size(193, 22);
            this.txtNameTK.TabIndex = 13;
            // 
            // butThoat
            // 
            this.butThoat.Location = new System.Drawing.Point(385, 389);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(75, 22);
            this.butThoat.TabIndex = 12;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // butListP
            // 
            this.butListP.Location = new System.Drawing.Point(159, 202);
            this.butListP.Name = "butListP";
            this.butListP.Size = new System.Drawing.Size(145, 52);
            this.butListP.TabIndex = 11;
            this.butListP.Text = "Danh sách phòng";
            this.butListP.UseVisualStyleBackColor = true;
            // 
            // butListSV
            // 
            this.butListSV.Location = new System.Drawing.Point(159, 144);
            this.butListSV.Name = "butListSV";
            this.butListSV.Size = new System.Drawing.Size(145, 52);
            this.butListSV.TabIndex = 10;
            this.butListSV.Text = "Danh Sách SV";
            this.butListSV.UseVisualStyleBackColor = true;
            // 
            // butTT
            // 
            this.butTT.Location = new System.Drawing.Point(159, 86);
            this.butTT.Name = "butTT";
            this.butTT.Size = new System.Drawing.Size(145, 52);
            this.butTT.TabIndex = 9;
            this.butTT.Text = "Thông tin TK";
            this.butTT.UseVisualStyleBackColor = true;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(209, 10);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.ReadOnly = true;
            this.txtMaTK.Size = new System.Drawing.Size(136, 22);
            this.txtMaTK.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã tài khoản :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Đăng ký SV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 52);
            this.button2.TabIndex = 15;
            this.button2.Text = "Thêm phòng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNameTK);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butListP);
            this.Controls.Add(this.butListSV);
            this.Controls.Add(this.butTT);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameTK;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.Button butListP;
        private System.Windows.Forms.Button butListSV;
        private System.Windows.Forms.Button butTT;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}