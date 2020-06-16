using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.BusinessLayer;
using app.Component;
using DevComponents.DotNetBar;

namespace app
{
    public partial class UsersType : Office2007Form
    {
        //Fields
        LoaiNguoiDungCtrl   m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh             quyDinh             = new QuyDinh();
        

        //Constructor
        public UsersType()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void UsersType_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThi(dGVLoaiNguoiDung, bindingNavigatorLoaiNguoiDung);
        }
        

        //BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVLoaiNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLoaiNguoiDung.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVLoaiNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_LoaiNguoiDungCtrl.ThemDongMoi();
            m_Row["MaLoai"]     = "LND" + quyDinh.LaySTT(dGVLoaiNguoiDung.Rows.Count + 1);
            m_Row["TenLoaiND"]  = "";
            m_LoaiNguoiDungCtrl.ThemLoaiNguoiDung(m_Row);
            bindingNavigatorLoaiNguoiDung.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVLoaiNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLoai")     == true &&
                KiemTraTruocKhiLuu("colTenLoaiND")  == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiNguoiDungCtrl.LuuLoaiNguoiDung();
            }
        }
        

        //DataError event
        private void dGVLoaiNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        
    }
}
