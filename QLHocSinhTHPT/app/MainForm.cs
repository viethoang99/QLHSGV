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
    public partial class MainForm : Office2007RibbonForm
    {
        //Fields
        NguoiDungCtrl   m_NguoiDungCtrl = new NguoiDungCtrl();
        frmDangNhap     m_FrmLogin      = null;
        Users    m_Users  = null;
        frmConnection   m_Connection    = null;
        

        //MainForm
        //Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        

        //Load
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (DataService.OpenConnection())
            {
                Default();
                DangNhap();

                this.Cursor = MyCursors.Create(System.IO.Path.Combine(Application.StartupPath, "Pointer.cur"));

                // Create the list of frequently used commands for the QAT Customize menu
                ribbonControl.QatFrequentCommands.Add(btnDangNhap);
                ribbonControl.QatFrequentCommands.Add(btnDangXuat);
                ribbonControl.QatFrequentCommands.Add(btnThoat);

                // Load Quick Access Toolbar layout if one is saved from last session...
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
                if (key != null)
                {
                    try
                    {
                        string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                        if (layout != "" && layout != null)
                            ribbonControl.QatLayout = layout;
                    }
                    finally
                    {
                        key.Close();
                    }
                }

                // Pulse the Application Button
                buttonFile.Pulse(11);
            }
            else
            {
                Default();
                ReConnection();
            }
        }
        

        //Kết nối lại CSDL
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
        

        //Lưu lại trạng thái khi thoát chương trình
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed...
            if (ribbonControl.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }
        
        

        //Form show
        //Menu start
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new frmDangNhap();
            
            m_FrmLogin.txtUsername.Text = "";
            m_FrmLogin.txtPassword.Text = "";
            m_FrmLogin.lblUserError.Text = "";
            m_FrmLogin.lblPassError.Text = "";

            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = "Không có";
            Default();
        }

        

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_Users == null || m_Users.IsDisposed)
            {
                m_Users = new Users();
                m_Users.MdiParent = this;
                m_Users.Show();
            }
            else
                m_Users.Activate();
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //Menu quan ly
        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLopHoc();
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoiLop();
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocKy();
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNamHoc();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNhapDiemChung();
        }

        private void ribbonBarMonHoc_LaunchDialog(object sender, EventArgs e)
        {
            ThamSo.ShowFormNhapDiemRieng();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKetQua();
        }

        private void btnHocLuc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocLuc();
        }

        private void btnHanhKiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHanhKiem();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocSinh();
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLop();
        }

        

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanCong();
        }
        

        //Menu thong ke
        private void btnKQHKTheoLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKQHKTheoLop();
        }

        private void btnKQHKTheoMon_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKQHKTheoMon();
        }

        private void btnKQCNTheoLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKQCNTheoLop();
        }

        private void btnKQCNTheoMon_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKQCNTheoMon();
        }

        private void btnDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanhSachHocSinh();
        }

        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanhSachGiaoVien();
        }

        private void btnDanhSachLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanhSachLopHoc();
        }
        

        //Tra cuu
        private void btnTimKiemHS_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTimKiemHS();
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTimKiemGV();
        }
        

        //Menu quy dinh
        frmQuyDinh m_FrmQD = new frmQuyDinh();
        private void btnSiSo_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormQuyDinh();
            m_FrmQD.tabControlPanelSiSo.Select();
        }
        private void btnDoTuoi_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormQuyDinh();
            m_FrmQD.tabControlPanelDoTuoi.Select();
        }
        private void btnThangDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormQuyDinh();
            m_FrmQD.tabControlPanelThangDiem.Select();
        }
        private void btnTruong_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormQuyDinh();
            m_FrmQD.tabControlPanelTruong.Select();
        }
        

        //Menu giup do
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormThongTin();
        }
        
        

        //Permissions
        //DangNhap
        public void DangNhap()
        {
            Cont:
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new frmDangNhap();

            if (m_FrmLogin.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmLogin.txtUsername.Text == "")
                {
                    m_FrmLogin.lblPassError.Text = "";
                    m_FrmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
                    goto Cont;
                }

                if (m_FrmLogin.txtPassword.Text == "")
                {
                    m_FrmLogin.lblUserError.Text = "";
                    m_FrmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu!";
                    goto Cont;
                }

                int ketQua = m_NguoiDungCtrl.DangNhap(m_FrmLogin.txtUsername.Text, m_FrmLogin.txtPassword.Text);

                switch (ketQua)
                {
                    case 0:
                        m_FrmLogin.lblPassError.Text = "";
                        m_FrmLogin.lblUserError.Text = "Người dùng này không tồn tại!";
                        goto Cont;
                    case 1:
                        m_FrmLogin.lblUserError.Text = "";
                        m_FrmLogin.lblPassError.Text = "Mật khẩu không hợp lệ!";
                        goto Cont;
                    case 2:
                        lblTenNguoiDung.Text = Utilities.NguoiDung.TenND;
                        Permissions(Utilities.NguoiDung.LoaiND.MaLoai);
                        break;
                }
            }
            else
                return;
        }
        

        //Phân quyền
        public void Permissions(String m_Per)
        {
            switch (m_Per)
            {
                case "LND001":  IsBGH();        break;
                case "LND002":  IsGiaoVien();   break;
                case "LND003":  IsGiaoVu();     break;
                default:        Default();      break;
            }
        }
        

        //Giao diện mặc định
        public void Default()
        {
            //True
            btnDangNhap.Enabled         = true;
            btnDangNhapContext.Enabled  = true;
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;
           

            //False
            btnDangXuat.Enabled         = false;
            btnDangXuatContext.Enabled  = false;
            //
            //
            btnQLNguoiDung.Enabled      = false;
            //
            //

            btnLopHoc.Enabled           = false;
            btnKhoiLop.Enabled          = false;
            btnHocKy.Enabled            = false;
            btnNamHoc.Enabled           = false;
            ribbonBarMonHoc.Enabled     = false;
            btnMonHoc.Enabled           = false;
            btnDiem.Enabled             = false;
            btnKetQua.Enabled           = false;
            btnHocLuc.Enabled           = false;
            btnHanhKiem.Enabled         = false;
            btnHocSinh.Enabled          = false;
            btnPhanLop.Enabled          = false;
            //
            //
            //
            btnGiaoVien.Enabled         = false;
            btnPhanCong.Enabled         = false;

            btnKQHKTheoLop.Enabled      = false;
            btnKQHKTheoMon.Enabled      = false;
            btnKQCNTheoLop.Enabled      = false;
            btnKQCNTheoMon.Enabled      = false;
            btnDanhSachHocSinh.Enabled  = false;
            btnDanhSachGiaoVien.Enabled = false;
            btnDanhSachLopHoc.Enabled   = false;

            btnTimKiemHS.Enabled        = false;
            btnTimKiemGV.Enabled        = false;

            btnSiSo.Enabled             = false;
            btnThangDiem.Enabled        = false;
            btnDoTuoi.Enabled           = false;
            btnTruong.Enabled           = false;
        }
        

        //Giao diện khi đăng nhập với quyền BGH
        public void IsBGH()
        {
            //False
            btnDangNhap.Enabled         = false;
            btnDangNhapContext.Enabled  = false;

            //True
            btnDangXuat.Enabled         = true;
            btnDangXuatContext.Enabled  = true;
            //
            //
            btnQLNguoiDung.Enabled      = true;
            //
            //
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;

            btnLopHoc.Enabled           = true;
            btnKhoiLop.Enabled          = true;
            btnHocKy.Enabled            = true;
            btnNamHoc.Enabled           = true;
            ribbonBarMonHoc.Enabled     = true;
            btnMonHoc.Enabled           = true;
            btnDiem.Enabled             = true;
            btnKetQua.Enabled           = true;
            btnHocLuc.Enabled           = true;
            btnHanhKiem.Enabled         = true;
            btnHocSinh.Enabled          = true;
            btnPhanLop.Enabled          = true;
            //
            //
            //
            btnGiaoVien.Enabled         = true;
            btnPhanCong.Enabled         = true;

            btnKQHKTheoLop.Enabled      = true;
            btnKQHKTheoMon.Enabled      = true;
            btnKQCNTheoLop.Enabled      = true;
            btnKQCNTheoMon.Enabled      = true;
            btnDanhSachHocSinh.Enabled  = true;
            btnDanhSachGiaoVien.Enabled = true;
            btnDanhSachLopHoc.Enabled   = true;

            btnTimKiemHS.Enabled        = true;
            btnTimKiemGV.Enabled        = true;

            btnSiSo.Enabled             = true;
            btnThangDiem.Enabled        = true;
            btnDoTuoi.Enabled           = true;
            btnTruong.Enabled           = true;

          
        }
        

        //Giao diện khi đăng nhập với quyền Giáo viên
        public void IsGiaoVien()
        {
            //True
            btnDangXuat.Enabled         = true;
            btnDangXuatContext.Enabled  = true;
            //
            //
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;

            ribbonBarMonHoc.Enabled     = true;
            btnMonHoc.Enabled           = true;
            btnDiem.Enabled             = true;

            btnKQHKTheoLop.Enabled      = true;
            btnKQHKTheoMon.Enabled      = true;
            btnKQCNTheoLop.Enabled      = true;
            btnKQCNTheoMon.Enabled      = true;
            btnDanhSachHocSinh.Enabled  = true;
            btnDanhSachGiaoVien.Enabled = true;
            btnDanhSachLopHoc.Enabled   = true;

            btnTimKiemHS.Enabled        = true;
            btnTimKiemGV.Enabled        = true;

            //False
            btnDangNhap.Enabled         = false;
            btnDangNhapContext.Enabled  = false;
            btnQLNguoiDung.Enabled      = false;
            //
            //

            btnLopHoc.Enabled           = false;
            btnKhoiLop.Enabled          = false;
            btnHocKy.Enabled            = false;
            btnNamHoc.Enabled           = false;
            btnKetQua.Enabled           = false;
            btnHocLuc.Enabled           = false;
            btnHanhKiem.Enabled         = false;
            btnHocSinh.Enabled          = false;
            btnPhanLop.Enabled          = false;
            //
            //
            //
            btnGiaoVien.Enabled         = false;
            btnPhanCong.Enabled         = false;

            btnSiSo.Enabled             = false;
            btnThangDiem.Enabled        = false;
            btnDoTuoi.Enabled           = false;
            btnTruong.Enabled           = false;
        }
        

        //Giao diện khi đăng nhập với quyền Giáo vụ
        public void IsGiaoVu()
        {
            //True
            btnDangXuat.Enabled         = true;
            btnDangXuatContext.Enabled  = true;
            //
            //
            btnThoat.Enabled            = true;
            btnThoatContext.Enabled     = true;
            
            btnLopHoc.Enabled           = true;
            btnKhoiLop.Enabled          = true;
            btnHocKy.Enabled            = true;
            btnNamHoc.Enabled           = true;
            btnKetQua.Enabled           = true;
            btnHocLuc.Enabled           = true;
            btnHanhKiem.Enabled         = true;
            ribbonBarMonHoc.Enabled     = true;
            btnMonHoc.Enabled           = true;
            btnDiem.Enabled             = true;
            btnHocSinh.Enabled          = true;
            btnPhanLop.Enabled          = true;
            //
            //
            //

            btnKQHKTheoLop.Enabled      = true;
            btnKQHKTheoMon.Enabled      = true;
            btnKQCNTheoLop.Enabled      = true;
            btnKQCNTheoMon.Enabled      = true;
            btnDanhSachHocSinh.Enabled  = true;
            btnDanhSachGiaoVien.Enabled = true;
            btnDanhSachLopHoc.Enabled   = true;

            btnTimKiemHS.Enabled        = true;
            btnTimKiemGV.Enabled        = true;

            //False
            btnDangNhap.Enabled         = false;
            btnDangNhapContext.Enabled  = false;
            btnQLNguoiDung.Enabled      = false;
            //
            //

            btnGiaoVien.Enabled         = false;
            btnPhanCong.Enabled         = false;

            btnSiSo.Enabled             = false;
            btnThangDiem.Enabled        = false;
            btnDoTuoi.Enabled           = false;
            btnTruong.Enabled           = false;
        }

        private void RibbonTabQuyDinh_Click(object sender, EventArgs e)
        {

        }
    }
}