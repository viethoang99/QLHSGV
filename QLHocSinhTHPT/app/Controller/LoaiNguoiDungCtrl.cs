using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataAccessLayer;

namespace app.Controller
{
    public class LoaiNguoiDungCtrl
    {
        LoaiNguoiDungData m_LoaiNguoiDungData = new LoaiNguoiDungData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();
            comboBox.DisplayMember = "TenLoaiND";
            comboBox.ValueMember = "MaLoai";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();
            cmbColumn.DisplayMember = "TenLoaiND";
            cmbColumn.ValueMember = "MaLoai";
            cmbColumn.DataPropertyName = "MaLoai";
            cmbColumn.HeaderText = "Loại người dùng";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiNguoiDungData.ThemDongMoi();
        }

        public void ThemLoaiNguoiDung(DataRow m_Row)
        {
            m_LoaiNguoiDungData.ThemLoaiNguoiDung(m_Row);
        }
        

        //Luu du lieu
        public bool LuuLoaiNguoiDung()
        {
            return m_LoaiNguoiDungData.LuuLoaiNguoiDung();
        }
        
    }
}
