﻿using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using app.Controller;
using app.Component;
using app.init;
using DevComponents.DotNetBar;

namespace app
{
    public partial class Mark : Office2007Form
    {
        //Fields
        NamHocCtrl      m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl       m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl         m_LopCtrl       = new LopCtrl();
        HocSinhCtrl     m_HocSinhCtrl   = new HocSinhCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        DiemCtrl        m_DiemCtrl      = new DiemCtrl();
        

        //Constructor
        public Mark()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void Mark_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
                m_HocSinhCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbHocSinh);
            }
        }
        

        //Click event
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lVXemDiem.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    int stt = Convert.ToInt32(item.SubItems[0].Text);
                    m_DiemCtrl.XoaDiem(stt);
                    lVXemDiem.Items.Remove(item);
                }
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            m_DiemCtrl.HienThiDanhSachXemDiem(lVXemDiem,
                                              cmbHocSinh.SelectedValue.ToString(),
                                              cmbMonHoc.SelectedValue.ToString(),
                                              cmbHocKy.SelectedValue.ToString(),
                                              cmbNamHoc.SelectedValue.ToString(),
                                              cmbLop.SelectedValue.ToString());
        }
        

        //SelectedIndexChanged event
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
                m_HocSinhCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbHocSinh);
            }

            cmbMonHoc.DataBindings.Clear();
            cmbHocSinh.DataBindings.Clear();
        }
        
    }
}
