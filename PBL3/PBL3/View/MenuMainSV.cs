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
    public partial class MenuMainSV : Form
    {
        Login lg { get; set; }
        public MenuMainSV(Login i)
        {
            InitializeComponent();
            lg = i;
            SetGUI();
        }
        public void SetGUI()
        {
            txtMaTK.Text = lg.Ma_TK;
           
            txtNameTK.Text = BLL_MenuAD.Instance.BLL_MenuADSetName(lg.Ma_TK);
        }
    }
}
