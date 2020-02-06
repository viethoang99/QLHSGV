using System;
using System.Text;
using System.Drawing;
using app.Bussiness;
using app.Component;
using app.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace app.Reports
{
    public partial class frptKetQuaCaNam_MonHoc : Office2007Form
    {
        #region Fields
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        MonHocCtrl  m_MonHocCtrl    = new MonHocCtrl();
        #endregion

        #region Constructor
        public frptKetQuaCaNam_MonHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frptKetQuaCaNam_MonHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
        }
        #endregion

        #region SelectedIndexChanged event
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
            cmbMonHoc.DataBindings.Clear();
        }
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}