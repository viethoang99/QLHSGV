using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace app.Component
{
    public partial class frmDangNhap : Office2007Form
    {
        //Constructor
        public frmDangNhap()
        {
            InitializeComponent();
        }
        

        //Click event
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        

        //Key event
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        
    }
}