﻿using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.BusinessLayer;
using DevComponents.DotNetBar;

namespace app
{
    public partial class Grades : Office2007Form
    {
        //Field
        KhoiLopCtrl m_KhoiLopCtrl   = new KhoiLopCtrl();
        

        //constructor
        public Grades()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void Grades_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);
        }
        

        //BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhoiLop.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_KhoiLopCtrl.ThemDongMoi();
            m_Row["MaKhoiLop"]  = "";
            m_Row["TenKhoiLop"] = "";
            m_KhoiLopCtrl.ThemKhoiLop(m_Row);
            bindingNavigatorKhoiLop.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVKhoiLop.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaKhoiLop")  == true &&
                KiemTraTruocKhiLuu("colTenkhoiLop") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KhoiLopCtrl.LuuKhoiLop();
            }
        }
        

        //DataError event
        private void dGVKhoiLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        
    }
}
