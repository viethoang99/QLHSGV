using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using app.DataAccessLayer;

namespace app.BusinessLayer
{
    public class KetQuaCtrl
    {
        KetQuaData m_KetQuaData = new KetQuaData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_KetQuaData.LayDsKetQua();
            comboBox.DisplayMember = "TenKetQua";
            comboBox.ValueMember = "MaKetQua";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KetQuaData.LayDsKetQua();
            cmbColumn.DisplayMember = "TenKetQua";
            cmbColumn.ValueMember = "MaKetQua";
            cmbColumn.DataPropertyName = "MaKetQua";
            cmbColumn.HeaderText = "Kết quả";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KetQuaData.LayDsKetQua();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_KetQuaData.ThemDongMoi();
        }

        public void ThemKetQua(DataRow m_Row)
        {
            m_KetQuaData.ThemKetQua(m_Row);
        }
        

        //Luu du lieu
        public bool LuuKetQua()
        {
            return m_KetQuaData.LuuKetQua();
        }
        
    }
}
