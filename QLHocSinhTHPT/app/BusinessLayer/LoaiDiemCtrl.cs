using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataAccessLayer;

namespace app.BusinessLayer
{
    public class LoaiDiemCtrl
    {
        LoaiDiemData m_LoaiDiemData = new LoaiDiemData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            comboBox.DisplayMember = "TenLoai";
            comboBox.ValueMember = "MaLoai";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            cmbColumn.DisplayMember = "TenLoai";
            cmbColumn.ValueMember = "MaLoai";
            cmbColumn.DataPropertyName = "MaLoai";
            cmbColumn.HeaderText = "Loại điểm";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiDiemData.ThemDongMoi();
        }

        public void ThemLoaiDiem(DataRow m_Row)
        {
            m_LoaiDiemData.ThemLoaiDiem(m_Row);
        }
        

        //Luu du lieu
        public bool LuuLoaiDiem()
        {
            return m_LoaiDiemData.LuuLoaiDiem();
        }
        
    }
}
