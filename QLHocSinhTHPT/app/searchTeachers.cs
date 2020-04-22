using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.Controller;
using DevComponents.DotNetBar;

namespace app
{
    public partial class searchTeachers : Office2007Form
    {
        //Fields
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        

        //Constructor
        public searchTeachers()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void searchTeachers_Load(object sender, EventArgs e)
        {
           // m_MonHocCtrl.HienThiComboBox(cmbCMon);
        }
        

        //BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //Tìm kiếm giáo viên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.TimKiemGiaoVien(txtHoTen,dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            
            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có giáo viên cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}