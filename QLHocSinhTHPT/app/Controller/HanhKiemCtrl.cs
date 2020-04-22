using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataLayer;

namespace app.Controller
{
    public class HanhKiemCtrl
    {
        HanhKiemData m_HanhKiemData = new HanhKiemData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HanhKiemData.LayDsHanhKiem();
            comboBox.DisplayMember = "TenHanhKiem";
            comboBox.ValueMember = "MaHanhKiem";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HanhKiemData.LayDsHanhKiem();
            cmbColumn.DisplayMember = "TenHanhKiem";
            cmbColumn.ValueMember = "MaHanhKiem";
            cmbColumn.DataPropertyName = "MaHanhKiem";
            cmbColumn.HeaderText = "Hạnh kiểm";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HanhKiemData.LayDsHanhKiem();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_HanhKiemData.ThemDongMoi();
        }

        public void ThemHanhKiem(DataRow m_Row)
        {
            m_HanhKiemData.ThemHanhKiem(m_Row);
        }
        

        //Luu du lieu
        public bool LuuHanhKiem()
        {
            return m_HanhKiemData.LuuHanhKiem();
        }
        
    }
}
