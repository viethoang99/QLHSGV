﻿using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Collections.Generic;
using DevComponents.Editors;
using app.DataTranferObject;
using app.DataAccessLayer;

namespace app.BusinessLayer
{
    public class LopCtrl
    {
        LopData m_LopData = new LopData();

        //Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_LopData.LayDsLop();
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }

        public void HienThiComboBox(String namHoc, ComboBox comboBox)
        {
            LopData m_LData = new LopData();
            
            comboBox.DataSource = m_LopData.LayDsLop(namHoc);
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }
        
        public void HienThiComboBox(String khoiLop, String namHoc, ComboBox comboBox)
        {
            LopData m_LData = new LopData();

            comboBox.DataSource = m_LData.LayDsLop(khoiLop, namHoc);
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }
        

        //Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LopData.LayDsLop();
            cmbColumn.DisplayMember = "TenLop";
            cmbColumn.ValueMember = "MaLop";
            cmbColumn.DataPropertyName = "MaLop";
            cmbColumn.HeaderText = "Lớp";
        }

        public void HienThiDataGridViewComboBoxColumn(String namHoc, DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LopData.LayDsLop(namHoc);
            cmbColumn.DisplayMember = "TenLop";
            cmbColumn.ValueMember = "MaLop";
            cmbColumn.DataPropertyName = "MaLop";
            cmbColumn.HeaderText = "Lớp";
        }
        

        //Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LopData.LayDsLop();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaLop,
                            TextBoxX txtTenLop,
                            ComboBoxEx cmbKhoiLop,
                            ComboBoxEx cmbNamHoc,
                            IntegerInput iniSiSo,
                            ComboBoxEx cmbGiaoVien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_LopData.LayDsLop();
            
            bN.BindingSource = bS;
            dGV.DataSource = bS;
            
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", bS, "MaLop");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", bS, "TenLop");
            
            cmbKhoiLop.DataBindings.Clear();
            cmbKhoiLop.DataBindings.Add("SelectedValue", bS, "MaKhoiLop");

            cmbNamHoc.DataBindings.Clear();
            cmbNamHoc.DataBindings.Add("SelectedValue", bS, "MaNamHoc");

            iniSiSo.DataBindings.Clear();
            iniSiSo.DataBindings.Add("Text", bS, "SiSo");
            
            cmbGiaoVien.DataBindings.Clear();
            cmbGiaoVien.DataBindings.Add("SelectedValue", bS, "MaGiaoVien");
        }
        

        //Lay danh sach lop do vao report
        public static IList<LopInfo> LayDsLop()
        {
            LopData m_LData = new LopData();
            DataTable m_DT = m_LData.LayDsLopForReport();

            IList<LopInfo> dS = new List<LopInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                LopInfo lop = new LopInfo();

                GiaoVienInfo gv = new GiaoVienInfo();
                gv.MaGiaoVien   = Convert.ToString(Row["MaGiaoVien"]);
                gv.TenGiaoVien  = Convert.ToString(Row["TenGiaoVien"]);

                KhoiLopInfo kl  = new KhoiLopInfo();
                kl.MaKhoiLop    = Convert.ToString(Row["MaKhoiLop"]);
                kl.TenKhoiLop   = Convert.ToString(Row["TenKhoiLop"]);

                NamHocInfo nh   = new NamHocInfo();
                nh.MaNamHoc     = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc    = Convert.ToString(Row["TenNamHoc"]);

                lop.MaLop       = Convert.ToString(Row["MaLop"]);
                lop.TenLop      = Convert.ToString(Row["TenLop"]);
                lop.KhoiLop     = kl.TenKhoiLop;
                lop.NamHoc      = nh;
                lop.SiSo        = Convert.ToInt32(Row["SiSo"]);
                lop.GiaoVien    = gv.TenGiaoVien;

                dS.Add(lop);
            }
            return dS;
        }

        public static IList<LopInfo> LayDsLop(String namHoc)
        {
            LopData m_LData = new LopData();
            DataTable m_DT = m_LData.LayDsLopForReport(namHoc);

            IList<LopInfo> dS = new List<LopInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                LopInfo lop = new LopInfo();

                GiaoVienInfo gv = new GiaoVienInfo();
                gv.MaGiaoVien = Convert.ToString(Row["MaGiaoVien"]);
                gv.TenGiaoVien = Convert.ToString(Row["TenGiaoVien"]);

                KhoiLopInfo kl = new KhoiLopInfo();
                kl.MaKhoiLop = Convert.ToString(Row["MaKhoiLop"]);
                kl.TenKhoiLop = Convert.ToString(Row["TenKhoiLop"]);

                NamHocInfo nh = new NamHocInfo();
                nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                lop.MaLop = Convert.ToString(Row["MaLop"]);
                lop.TenLop = Convert.ToString(Row["TenLop"]);
                lop.KhoiLop = kl.TenKhoiLop;
                lop.NamHoc = nh;
                lop.SiSo = Convert.ToInt32(Row["SiSo"]);
                lop.GiaoVien = gv.TenGiaoVien;
                
                dS.Add(lop);
            }
            return dS;
        }
        

        //Them moi
        public DataRow ThemDongMoi()
        {
            return m_LopData.ThemDongMoi();
        }

        public void ThemLop(DataRow m_Row)
        {
            m_LopData.ThemLop(m_Row);
        }
        

        //Luu du lieu
        public bool LuuLop()
        {
            return m_LopData.LuuLop();
        }

        public void LuuLop(String maLop, String tenLop, String maKhoiLop, String maNamHoc, int siSo, String maGiaoVien)
        {
            m_LopData.LuuLop(maLop, tenLop, maKhoiLop, maNamHoc, siSo, maGiaoVien);
        }
        

        //Tim kiem
        public void TimTheoMa(String m_MaLop)
        {
            m_LopData.TimTheoMa(m_MaLop);
        }

        public void TimTheoTen(String m_TenLop)
        {
            m_LopData.TimTheoTen(m_TenLop);
        }
        
    }
}
