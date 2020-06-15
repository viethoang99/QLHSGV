using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataAccessLayer;

namespace app.Controller
{
    public class NamHocCtrl
    {
        NamHocData m_NamHocData = new NamHocData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            NamHocData m_NHData = new NamHocData();

            comboBox.DataSource = m_NHData.LayDsNamHoc();
            comboBox.DisplayMember = "TenNamHoc";
            comboBox.ValueMember = "MaNamHoc";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NamHocData.LayDsNamHoc();
            cmbColumn.DisplayMember = "TenNamHoc";
            cmbColumn.ValueMember = "MaNamHoc";
            cmbColumn.DataPropertyName = "MaNamHoc";
            cmbColumn.HeaderText = "Năm học";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NamHocData.LayDsNamHoc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_NamHocData.ThemDongMoi();
        }

        public void ThemNamHoc(DataRow m_Row)
        {
            m_NamHocData.ThemNamHoc(m_Row);
        }
        

        //Luu du lieu
        public bool LuuNamHoc()
        {
            return m_NamHocData.LuuNamHoc();
        }
        
    }
}
