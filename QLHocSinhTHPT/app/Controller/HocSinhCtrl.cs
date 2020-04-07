using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using app.DataLayer;
using app.init;

namespace app.Controller
{
    public class HocSinhCtrl
    {
        HocSinhData m_HocSinhData = new HocSinhData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HocSinhData.LayDsHocSinh();
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
        {
            HocSinhData m_HSData = new HocSinhData();

            comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocSinhData.LayDsHocSinh();
            cmbColumn.DisplayMember = "HoTen";
            cmbColumn.ValueMember = "MaHocSinh";
            cmbColumn.DataPropertyName = "MaHocSinh";
            cmbColumn.HeaderText = "Học sinh";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocSinhData.LayDsHocSinh();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaHocSinh,
                            TextBoxX txtTenHocSinh,
                            TextBoxX txtGioiTinh,
                            DateTimeInput dtpNgaySinh,
                            TextBoxX txtNoiSinh
                           )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinh();

            //DataTable dT = m_HocSinhData.LayDsHocSinh();
            //bool gioiTinh = Convert.ToBoolean(dT.Rows[0]["GioiTinh"]);

            //if (gioiTinh)
            //    ckbGTinhNu.Checked = true;
            //else
            //    ckbGTinhNam.Checked = true;

            txtMaHocSinh.DataBindings.Clear();
            //txtMaHocSinh.DataBindings.Add("Text", bS, "MaHocSinh");

            txtTenHocSinh.DataBindings.Clear();
            // txtTenHocSinh.DataBindings.Add("Text", bS, "HoTen");

            txtGioiTinh.DataBindings.Clear();
            // txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");

            dtpNgaySinh.DataBindings.Clear();
            //dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtNoiSinh.DataBindings.Clear();
            //txtNoiSinh.DataBindings.Add("Text", bS, "NoiSinh");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        public void HienThiDsHocSinhTheoLop(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, lop);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThiDsHocSinhTheoLop(String namHoc, String khoiLop, String lop, ListViewEx lV)
        {
            DataTable m_DT = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, khoiLop, lop);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaHocSinh"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());

                lV.Items.Add(item);
            }
        }

        public DataTable HienThiDsHocSinhTheoNamHoc(String namHoc)
        {
            return m_HocSinhData.LayDsHocSinhTheoNamHoc(namHoc);
        }

        public void XoaHSKhoiBangPhanLop(String namHocCu, String khoiLopCu, String lopCu, ListViewEx hocSinh)
        {
            //foreach (ListViewItem item in hocSinh.Items)
            //{
            string temp = ClassDivision.HSChuyen;
            m_HocSinhData.XoaHSKhoiBangPhanLop(namHocCu, khoiLopCu, lopCu, temp);
            //m_HocSinhData.XoaHSKhoiBangPhanLop(namHocCu, khoiLopCu, lopCu, );
            //}
        }

        public void LuuHSVaoBangPhanLop(String namHocMoi, String khoiLopMoi, String lopMoi, ListViewEx hocSinh)
        {
            //foreach (ListViewItem item in hocSinh.Items)
            //{
                string temp = ClassDivision.HSChuyen;
                m_HocSinhData.LuuHSVaoBangPhanLop(namHocMoi, khoiLopMoi, lopMoi,temp);
            //}
        }

        #region Lay danh sach hoc sinh do vao report
        public static IList<HocSinhInfo> LayDsHocSinh()
        {
            HocSinhData m_HSData = new HocSinhData();
            DataTable m_DT = m_HSData.LayDsHocSinhForReport();

            IList<HocSinhInfo> dS = new List<HocSinhInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                HocSinhInfo hs = new HocSinhInfo();
                hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen = Convert.ToString(Row["HoTen"]);
                hs.GioiTinh = Convert.ToString(Row["GioiTinh"]).Trim();
                hs.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                hs.NoiSinh = Convert.ToString(Row["NoiSinh"]);

                dS.Add(hs);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.ThemDongMoi();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.ThemHocSinh(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuHocSinh()
        {
            return m_HocSinhData.LuuHocSinh();
        }

        public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String noiSinh)
        {
            m_HocSinhData.LuuHocSinh(maHocSinh, hoTen, gioiTinh, ngaySinh, noiSinh);
        }
        #endregion

        #region Tim kiem
        public void TimKiemHocSinh(TextBoxX txtHoTen,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh(txtHoTen.Text);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaHocSinh)
        {
            m_HocSinhData.TimTheoMa(m_MaHocSinh);
        }

        public void TimTheoTen(String m_TenHocSinh)
        {
            m_HocSinhData.TimTheoTen(m_TenHocSinh);
        }
        #endregion
    }
}
