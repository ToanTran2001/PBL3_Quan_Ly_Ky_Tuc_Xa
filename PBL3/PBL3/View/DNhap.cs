using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class DNhap : Form
    {
        public DNhap()
        {
            InitializeComponent();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Login i = BLL_Login.Instance.DangNhap(txtUser.Text, txtPass.Text);
            if (i == null) MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!");
            else
            {
                if (i.Loai_TK == 1)
                {
                    MenuAdmin f = new MenuAdmin(i);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MenuMainSV f = new MenuMainSV(i);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                this.Close();
            }
        }

        private void DNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
