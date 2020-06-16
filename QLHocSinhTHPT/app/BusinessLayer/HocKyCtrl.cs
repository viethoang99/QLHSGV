using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataAccessLayer;

namespace app.BusinessLayer
{
    public class HocKyCtrl
    {
        HocKyData m_HocKyData = new HocKyData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            HocKyData m_HKData = new HocKyData();

            comboBox.DataSource = m_HKData.LayDsHocKy();
            comboBox.DisplayMember = "TenHocKy";
            comboBox.ValueMember = "MaHocKy";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocKyData.LayDsHocKy();
            cmbColumn.DisplayMember = "TenHocKy";
            cmbColumn.ValueMember = "MaHocKy";
            cmbColumn.DataPropertyName = "MaHocKy";
            cmbColumn.HeaderText = "Học kỳ";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocKyData.LayDsHocKy();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_HocKyData.ThemDongMoi();
        }
        
        public void ThemHocKy(DataRow m_Row)
        {
            m_HocKyData.ThemHocKy(m_Row);
        }
        

        //Luu du lieu
        public bool LuuHocKy()
        {
            return m_HocKyData.LuuHocKy();
        }
        
    }
}