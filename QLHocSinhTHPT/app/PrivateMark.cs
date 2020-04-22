using System;
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
    public partial class PrivateMark : Office2007Form
    {
        //Fields
        NamHocCtrl      m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl       m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl         m_LopCtrl       = new LopCtrl();
        HocSinhCtrl     m_HocSinhCtrl   = new HocSinhCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        LoaiDiemCtrl    m_LoaiDiemCtrl  = new LoaiDiemCtrl();
        DiemCtrl        m_DiemCtrl      = new DiemCtrl();
        QuyDinh         quyDinh         = new QuyDinh();
        

        //Constructor
        public PrivateMark()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void PrivateMark_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            m_LoaiDiemCtrl.HienThiComboBox(cmbLoaiDiem);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
                m_HocSinhCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbHocSinh);
            }
        }
        

        //BindingNavigatorItems
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lVDiem.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lVDiem.Items.Remove(item);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int numberOfRow = lVDiem.Items.Count;
            for (int i = 0; i < numberOfRow; i++)
            {
                ListViewItem item = lVDiem.Items[i];
                DiemInfo diem = new DiemInfo();
                diem = (DiemInfo)item.Tag;

                m_DiemCtrl.LuuDiem(diem.HocSinh.MaHocSinh, diem.MonHoc.MaMonHoc, diem.HocKy.MaHocKy, diem.NamHoc.MaNamHoc, diem.Lop.MaLop, diem.LoaiDiem.MaLoai, diem.Diem);
            }
            lVDiem.Items.Clear();

            MessageBoxEx.Show("Đã lưu vào bảng điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormXemDiem();
        }
        

        //Click event
        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (quyDinh.KiemTraDiem(txtDiem.Text) == false || txtDiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem item = new ListViewItem();

                item.Text = cmbHocSinh.SelectedValue.ToString();
                item.SubItems.Add(cmbHocSinh.Text);
                item.SubItems.Add(cmbHocKy.Text);
                item.SubItems.Add(cmbMonHoc.Text);
                item.SubItems.Add(cmbLoaiDiem.Text);
                item.SubItems.Add(txtDiem.Text);

                DiemInfo diem = new DiemInfo();
                diem.HocSinh.MaHocSinh  = cmbHocSinh.SelectedValue.ToString();
                diem.MonHoc.MaMonHoc    = cmbMonHoc.SelectedValue.ToString();
                diem.HocKy.MaHocKy      = cmbHocKy.SelectedValue.ToString();
                diem.NamHoc.MaNamHoc    = cmbNamHoc.SelectedValue.ToString();
                diem.Lop.MaLop          = cmbLop.SelectedValue.ToString();
                diem.LoaiDiem.MaLoai    = cmbLoaiDiem.SelectedValue.ToString();
                diem.Diem               = Convert.ToSingle(txtDiem.Text);

                item.Tag = diem;

                lVDiem.Items.Add(item);
            }
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
        

        //Key event
        private void txtDiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (quyDinh.KiemTraDiem(txtDiem.Text) == false || txtDiem.Text == "")
                {
                    MessageBoxEx.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = cmbHocSinh.SelectedValue.ToString();
                    item.SubItems.Add(cmbHocSinh.Text);
                    item.SubItems.Add(cmbHocKy.Text);
                    item.SubItems.Add(cmbMonHoc.Text);
                    item.SubItems.Add(cmbLoaiDiem.Text);
                    item.SubItems.Add(txtDiem.Text);

                    DiemInfo diem = new DiemInfo();
                    diem.HocSinh.MaHocSinh  = cmbHocSinh.SelectedValue.ToString();
                    diem.MonHoc.MaMonHoc    = cmbMonHoc.SelectedValue.ToString();
                    diem.HocKy.MaHocKy      = cmbHocKy.SelectedValue.ToString();
                    diem.NamHoc.MaNamHoc    = cmbNamHoc.SelectedValue.ToString();
                    diem.Lop.MaLop          = cmbLop.SelectedValue.ToString();
                    diem.LoaiDiem.MaLoai    = cmbLoaiDiem.SelectedValue.ToString();
                    diem.Diem               = Convert.ToSingle(txtDiem.Text);

                    item.Tag = diem;

                    lVDiem.Items.Add(item);
                }
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}