using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.Controller;
using DevComponents.DotNetBar;

namespace app
{
    public partial class searchStudents : Office2007Form
    {
        public static string rs;
        //Fields 
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        

        //Constructor
        public searchStudents()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void searchStudents_Load(object sender, EventArgs e)
        {
        }
        

        //BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //Tìm kiếm học sinh
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.TimKiemHocSinh(txtHoTen, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            
            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có học sinh cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}