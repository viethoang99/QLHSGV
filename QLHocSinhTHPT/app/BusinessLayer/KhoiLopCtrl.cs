using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataAccessLayer;

namespace app.BusinessLayer
{
    public class KhoiLopCtrl
    {
        KhoiLopData m_KhoiLopData = new KhoiLopData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_KhoiLopData.LayDsKhoiLop();
            comboBox.DisplayMember = "TenKhoiLop";
            comboBox.ValueMember = "MaKhoiLop";
        }
        

        //Hien thi ComboBox khoi lop, phu thuoc vao khoi lop cu
        public void HienThiComboBox(String khoiLopCu, ComboBoxEx cmbKhoiLopMoi)
        {
            KhoiLopData m_KLData = new KhoiLopData();
            cmbKhoiLopMoi.DataSource = m_KLData.LayDsKhoiLop(khoiLopCu);
            cmbKhoiLopMoi.DisplayMember = "TenKhoiLop";
            cmbKhoiLopMoi.ValueMember = "MaKhoiLop";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KhoiLopData.LayDsKhoiLop();
            cmbColumn.DisplayMember = "TenKhoiLop";
            cmbColumn.ValueMember = "MaKhoiLop";
            cmbColumn.DataPropertyName = "MaKhoiLop";
            cmbColumn.HeaderText = "Khối lớp";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KhoiLopData.LayDsKhoiLop();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.ThemDongMoi();
        }

        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.ThemKhoiLop(m_Row);
        }
        

        //Luu du lieu
        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.LuuKhoiLop();
        }
        
    }
}
