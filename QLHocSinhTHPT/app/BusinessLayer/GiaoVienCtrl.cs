using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Collections.Generic;
using app.DataAccessLayer;
using app.DataTranferObject;

namespace app.BusinessLayer
{
    public class GiaoVienCtrl
    {
        GiaoVienData m_GiaoVienData = new GiaoVienData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_GiaoVienData.LayDsGiaoVien();
            comboBox.DisplayMember = "TenGiaoVien";
            comboBox.ValueMember = "MaGiaoVien";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_GiaoVienData.LayDsGiaoVien();
            cmbColumn.DisplayMember = "TenGiaoVien";
            cmbColumn.ValueMember = "MaGiaoVien";
            cmbColumn.DataPropertyName = "MaGiaoVien";
            cmbColumn.HeaderText = "Giáo viên";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_GiaoVienData.LayDsGiaoVien();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaGiaoVien,
                            TextBoxX txtTenGiaoVien,
                            TextBoxX txtDiaChi,
                            TextBoxX txtDienThoai,
                            ComboBoxEx cmbMonHoc)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_GiaoVienData.LayDsGiaoVien();

            txtMaGiaoVien.DataBindings.Clear();
            txtMaGiaoVien.DataBindings.Add("Text", bS, "MaGiaoVien");

            txtTenGiaoVien.DataBindings.Clear();
            txtTenGiaoVien.DataBindings.Add("Text", bS, "TenGiaoVien");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            cmbMonHoc.DataBindings.Clear();
            cmbMonHoc.DataBindings.Add("SelectedValue", bS, "MaMonHoc");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        

        //Lay danh sach giao vien do vao report
        public static IList<GiaoVienInfo> LayDsGiaoVien()
        {
            GiaoVienData m_GVData = new GiaoVienData();
            DataTable m_DT = m_GVData.LayDsGiaoVienForReport();

            IList<GiaoVienInfo> dS = new List<GiaoVienInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                GiaoVienInfo gv = new GiaoVienInfo();
                gv.MaGiaoVien = Convert.ToString(Row["MaGiaoVien"]);
                gv.TenGiaoVien = Convert.ToString(Row["TenGiaoVien"]);
                gv.DiaChi = Convert.ToString(Row["DiaChi"]);
                gv.DienThoai = Convert.ToString(Row["DienThoai"]);
                gv.MonHoc = Convert.ToString(Row["TenMonHoc"]);

                dS.Add(gv);
            }
            return dS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_GiaoVienData.ThemDongMoi();
        }
        

        public void ThemGiaoVien(DataRow m_Row)
        {
            m_GiaoVienData.ThemGiaoVien(m_Row);
        }
        

        //Luu du lieu
        public bool LuuGiaoVien()
        {
            return m_GiaoVienData.LuuGiaoVien();
        }

        public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon)
        {
            m_GiaoVienData.LuuGiaoVien(maGiaoVien, tenGiaoVien, diaChi, dienThoai, chuyenMon);
        }
        

        //Tìm kiem
        public void TimKiemGiaoVien(TextBoxX txtHoTen,                                   
                                    DataGridViewX dGV,
                                    BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_GiaoVienData.TimKiemGiaoVien(txtHoTen.Text);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaGiaoVien)
        {
            m_GiaoVienData.TimTheoMa(m_MaGiaoVien);
        }
        
        public void TimTheoTen(String m_TenGiaoVien)
        {
            m_GiaoVienData.TimTheoTen(m_TenGiaoVien);
        }
        
    }
}
