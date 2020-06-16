using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.BusinessLayer;
using app.Component;
using DevComponents.DotNetBar;

namespace app
{
    public partial class StudentsForm : Office2007Form
    {
        public static int countRowsPre;
        public static int countRowsNext;
        public static String maHS;
        public static String hoTen;
        public static String gioiTinh;
        public static DateTime nSinh;
        public static String noiSinh;
        public static String temp;
        DataTable data = new DataTable();
        //Fields
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        QuyDinh quyDinh = new QuyDinh();
        

        //Constructor
        public StudentsForm()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, dtpNgaySinh, txtNoiSinh);
            countRowsPre = dGVHocSinh.RowCount;
        }
        

        //BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVHocSinh.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHocSinh.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVHocSinh.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_HocSinhCtrl.ThemDongMoi();
            m_Row["MaHocSinh"] = "HS" + quyDinh.LaySTT(dGVHocSinh.Rows.Count + 1);
            m_Row["HoTen"] = "";
            m_Row["GioiTinh"] = false;
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["NoiSinh"] = "";
            m_HocSinhCtrl.ThemHocSinh(m_Row);
            bindingNavigatorHocSinh.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, dtpNgaySinh, txtNoiSinh);
        }

        public String KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                }
                temp = row.Cells[cellString].Value.ToString();
            }
            return temp;
        }

        public String KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            countRowsNext = dGVHocSinh.RowCount;
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());
                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi học sinh " + row.Cells["colHoTen"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                }
                temp = row.Cells[doTuoiColumn].Value.ToString();
            }
            return temp;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocSinh").Equals("") != true &&
                KiemTraTruocKhiLuu("colHoTen").Equals("") != true &&
                KiemTraTruocKhiLuu("colNoiSinh").Equals("") != true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("colNgaySinh").Equals("") != true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_HocSinhCtrl.LuuHocSinh();
                    if (countRowsNext > countRowsPre)
                    {
                        maHS = KiemTraTruocKhiLuu("colMaHocSinh");
                        hoTen = KiemTraTruocKhiLuu("colHoTen");
                        noiSinh = KiemTraTruocKhiLuu("colNoiSinh");
                        nSinh = Convert.ToDateTime(KiemTraDoTuoiTruocKhiLuu("colNgaySinh").ToString());
                        if (KiemTraTruocKhiLuu("colGioiTinh").Equals("Nam"))
                            gioiTinh = "Nam";
                        else gioiTinh = "Nữ";
                        m_HocSinhCtrl.LuuHocSinh(maHS, hoTen, gioiTinh, nSinh, noiSinh);
                    }
                }
            }
        }
        

        //DataError event
        private void dGVHocSinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        

        //Tìm kiếm học sinh
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemHocSinh();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemHocSinh();
        }

        void TimKiemHocSinh()
        {
            if (chkTimTheoMa.Checked == true)
            {
                m_HocSinhCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_HocSinhCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }
        

        //Click event
        private void dGVHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtGioiTinh.Text == "True")
                ckbGTinhNu.Checked = true;
            else
                ckbGTinhNam.Checked = true;
        }


        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            string gioiTinh;
            if (ckbGTinhNu.Checked == true)
                gioiTinh = "Nữ";
            else
                gioiTinh = "Nam";
            if (txtMaHocSinh.Text != "" &&
                txtTenHocSinh.Text != "" &&
                txtNoiSinh.Text != "" &&
                dtpNgaySinh.Value != null
               )
            {
                if (quyDinh.KiemTraDoTuoi(dtpNgaySinh.Value) == true)
                {
                    m_HocSinhCtrl.LuuHocSinh(txtMaHocSinh.Text, txtTenHocSinh.Text, gioiTinh, dtpNgaySinh.Value, txtNoiSinh.Text);
                    m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, dtpNgaySinh, txtNoiSinh);

                    bindingNavigatorHocSinh.BindingSource.MoveLast();
                }
                else
                    MessageBoxEx.Show("Tuổi của học sinh " + txtTenHocSinh.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        

        private void DGVHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}