﻿using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.Controller;
using DevComponents.DotNetBar;

namespace app
{
    public partial class frmTimKiemHS : Office2007Form
    {
        public static string rs;
        #region Fields 
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        #endregion

        #region Constructor
        public frmTimKiemHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmTimKiemHS_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Tìm kiếm học sinh
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.TimKiemHocSinh(txtHoTen, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            
            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có học sinh cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}