namespace app
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            System.Windows.Forms.DialogResult rs;
            rs = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình Quản lý điểm học sinh không?", "THOÁT KHỎI CHƯƠNG TRÌNH?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
            if (disposing && (components != null))
                components.Dispose();
        }

        //Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanelThongKe = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarXuatDanhSach = new DevComponents.DotNetBar.RibbonBar();
            this.btnDanhSachHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDanhSachGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnDanhSachLopHoc = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarKQCuoiNam = new DevComponents.DotNetBar.RibbonBar();
            this.btnKQCNTheoLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnKQCNTheoMon = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarKQHocKy = new DevComponents.DotNetBar.RibbonBar();
            this.btnKQHKTheoLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnKQHKTheoMon = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelQuyDinh = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarQuyDinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnSiSo = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoTuoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnThangDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnTruong = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelQuanLy = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarGiaoVien = new DevComponents.DotNetBar.RibbonBar();
            this.btnGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanCong = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarHocSinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanLop = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarKetQua = new DevComponents.DotNetBar.RibbonBar();
            this.btnKetQua = new DevComponents.DotNetBar.ButtonItem();
            this.btnHocLuc = new DevComponents.DotNetBar.ButtonItem();
            this.btnHanhKiem = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarMonHoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnMonHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnDiem = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarNamHoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnHocKy = new DevComponents.DotNetBar.ButtonItem();
            this.btnNamHoc = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarLop = new DevComponents.DotNetBar.RibbonBar();
            this.btnLopHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnKhoiLop = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelTraCuu = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarTraCuu = new DevComponents.DotNetBar.RibbonBar();
            this.btnTimKiemHS = new DevComponents.DotNetBar.ButtonItem();
            this.btnTimKiemGV = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabThongKe = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabTraCuu = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuyDinh = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonFile = new DevComponents.DotNetBar.Office2007StartButton();
            this.menuFileContainer = new DevComponents.DotNetBar.ItemContainer();
            this.menuFileItems = new DevComponents.DotNetBar.ItemContainer();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLNguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonTabItemGroup = new DevComponents.DotNetBar.RibbonTabItemGroup();
            this.bottomBar = new DevComponents.DotNetBar.Bar();
            this.lblTenNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.lblNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.tabStrip = new DevComponents.DotNetBar.TabStrip();
            this.mdiClient = new System.Windows.Forms.MdiClient();
            this.ctxMenuMain = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenuMain = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangNhapContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuatContext = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoatContext = new DevComponents.DotNetBar.ButtonItem();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanelThongKe.SuspendLayout();
            this.ribbonPanelQuyDinh.SuspendLayout();
            this.ribbonPanelQuanLy.SuspendLayout();
            this.ribbonPanelTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            this.bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanelQuanLy);
            this.ribbonControl.Controls.Add(this.ribbonPanelQuyDinh);
            this.ribbonControl.Controls.Add(this.ribbonPanelTraCuu);
            this.ribbonControl.Controls.Add(this.ribbonPanelThongKe);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabQuanLy,
            this.ribbonTabThongKe,
            this.ribbonTabTraCuu,
            this.ribbonTabQuyDinh});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile,
            this.qatCustomizeItem});
            this.ribbonControl.Size = new System.Drawing.Size(792, 149);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl.SystemText.MaximizeRibbonText = "Cực &đại menu Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Cực &tiểu menu Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Thêm vào thanh công cụ truy xuất nhanh";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "Thanh công cụ truy xuất nhanh";
            this.ribbonControl.SystemText.QatCustomizeText = "&Tùy chọn đối tượng hiển thị...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Thêm >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Hủy bỏ";
            this.ribbonControl.SystemText.QatDialogCaption = "TÙY CHỌN ĐỐI TƯỢNG HIỂN THỊ";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Chọn đối tượng từ danh sách:";
            this.ribbonControl.SystemText.QatDialogOkButton = "Đồng ý";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Dời thanh công cụ xuống dưới menu Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Loại bỏ";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Dời thanh công cụ lên trên menu Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Dời thanh công cụ xuống dưới menu Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Loại bỏ khỏi thanh công cụ truy xuất nhanh";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabGroups.AddRange(new DevComponents.DotNetBar.RibbonTabItemGroup[] {
            this.ribbonTabItemGroup});
            this.ribbonControl.TabGroupsVisible = true;
            this.ribbonControl.TabIndex = 0;
            // 
            // ribbonPanelThongKe
            // 
            this.ribbonPanelThongKe.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelThongKe, this.btnMenuMain);
            this.ribbonPanelThongKe.Controls.Add(this.ribbonBarXuatDanhSach);
            this.ribbonPanelThongKe.Controls.Add(this.ribbonBarKQCuoiNam);
            this.ribbonPanelThongKe.Controls.Add(this.ribbonBarKQHocKy);
            this.ribbonPanelThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelThongKe.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelThongKe.Name = "ribbonPanelThongKe";
            this.ribbonPanelThongKe.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelThongKe.Size = new System.Drawing.Size(792, 91);
            this.ribbonPanelThongKe.TabIndex = 3;
            this.ribbonPanelThongKe.Visible = false;
            // 
            // ribbonBarXuatDanhSach
            // 
            this.ribbonBarXuatDanhSach.AutoOverflowEnabled = true;
            this.ribbonBarXuatDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarXuatDanhSach.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDanhSachHocSinh,
            this.btnDanhSachGiaoVien,
            this.btnDanhSachLopHoc});
            this.ribbonBarXuatDanhSach.Location = new System.Drawing.Point(323, 0);
            this.ribbonBarXuatDanhSach.Name = "ribbonBarXuatDanhSach";
            this.ribbonBarXuatDanhSach.Size = new System.Drawing.Size(198, 88);
            this.ribbonBarXuatDanhSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarXuatDanhSach.TabIndex = 3;
            this.ribbonBarXuatDanhSach.Text = "Xuất Danh Sách";
            // 
            // btnDanhSachHocSinh
            // 
            this.btnDanhSachHocSinh.Image = global::app.Properties.Resources.giaovien;
            this.btnDanhSachHocSinh.ImagePaddingHorizontal = 8;
            this.btnDanhSachHocSinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhSachHocSinh.Name = "btnDanhSachHocSinh";
            this.btnDanhSachHocSinh.SplitButton = true;
            this.btnDanhSachHocSinh.Text = "<div align=\"center\">Danh sách<br/>học sinh</div>";
            this.btnDanhSachHocSinh.Tooltip = "Danh sách học sinh";
            this.btnDanhSachHocSinh.Click += new System.EventHandler(this.btnDanhSachHocSinh_Click);
            // 
            // btnDanhSachGiaoVien
            // 
            this.btnDanhSachGiaoVien.Image = global::app.Properties.Resources.pupils;
            this.btnDanhSachGiaoVien.ImagePaddingHorizontal = 8;
            this.btnDanhSachGiaoVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhSachGiaoVien.Name = "btnDanhSachGiaoVien";
            this.btnDanhSachGiaoVien.SplitButton = true;
            this.btnDanhSachGiaoVien.Text = "<div align=\"center\">Danh sách<br/>giáo viên</div>";
            this.btnDanhSachGiaoVien.Tooltip = "Danh sách giáo viên";
            this.btnDanhSachGiaoVien.Click += new System.EventHandler(this.btnDanhSachGiaoVien_Click);
            // 
            // btnDanhSachLopHoc
            // 
            this.btnDanhSachLopHoc.Image = global::app.Properties.Resources.school;
            this.btnDanhSachLopHoc.ImagePaddingHorizontal = 8;
            this.btnDanhSachLopHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhSachLopHoc.Name = "btnDanhSachLopHoc";
            this.btnDanhSachLopHoc.SplitButton = true;
            this.btnDanhSachLopHoc.Text = "<div align=\"center\">Danh sách<br/>lớp học</div>";
            this.btnDanhSachLopHoc.Tooltip = "Danh sách lớp học";
            this.btnDanhSachLopHoc.Click += new System.EventHandler(this.btnDanhSachLopHoc_Click);
            // 
            // ribbonBarKQCuoiNam
            // 
            this.ribbonBarKQCuoiNam.AutoOverflowEnabled = true;
            this.ribbonBarKQCuoiNam.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarKQCuoiNam.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnKQCNTheoLop,
            this.btnKQCNTheoMon});
            this.ribbonBarKQCuoiNam.Location = new System.Drawing.Point(178, 0);
            this.ribbonBarKQCuoiNam.Name = "ribbonBarKQCuoiNam";
            this.ribbonBarKQCuoiNam.Size = new System.Drawing.Size(145, 88);
            this.ribbonBarKQCuoiNam.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarKQCuoiNam.TabIndex = 2;
            this.ribbonBarKQCuoiNam.Text = "Kết Quả Cuối Năm";
            // 
            // btnKQCNTheoLop
            // 
            this.btnKQCNTheoLop.Image = global::app.Properties.Resources._9;
            this.btnKQCNTheoLop.ImagePaddingHorizontal = 8;
            this.btnKQCNTheoLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKQCNTheoLop.Name = "btnKQCNTheoLop";
            this.btnKQCNTheoLop.SplitButton = true;
            this.btnKQCNTheoLop.Text = "Kết quả lớp học";
            this.btnKQCNTheoLop.Tooltip = "Kết quả cả năm theo lớp học";
            this.btnKQCNTheoLop.Click += new System.EventHandler(this.btnKQCNTheoLop_Click);
            // 
            // btnKQCNTheoMon
            // 
            this.btnKQCNTheoMon.Image = global::app.Properties.Resources._11;
            this.btnKQCNTheoMon.ImagePaddingHorizontal = 8;
            this.btnKQCNTheoMon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKQCNTheoMon.Name = "btnKQCNTheoMon";
            this.btnKQCNTheoMon.SplitButton = true;
            this.btnKQCNTheoMon.Text = "<div align=\"center\">Kết quả cả năm<br/>theo môn học</div>";
            this.btnKQCNTheoMon.Tooltip = "Kết quả cả năm theo môn học";
            this.btnKQCNTheoMon.Click += new System.EventHandler(this.btnKQCNTheoMon_Click);
            // 
            // ribbonBarKQHocKy
            // 
            this.ribbonBarKQHocKy.AutoOverflowEnabled = true;
            this.ribbonBarKQHocKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarKQHocKy.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnKQHKTheoLop,
            this.btnKQHKTheoMon});
            this.ribbonBarKQHocKy.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarKQHocKy.Name = "ribbonBarKQHocKy";
            this.ribbonBarKQHocKy.Size = new System.Drawing.Size(175, 88);
            this.ribbonBarKQHocKy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarKQHocKy.TabIndex = 1;
            this.ribbonBarKQHocKy.Text = "Kết Quả Học Kỳ";
            // 
            // btnKQHKTheoLop
            // 
            this.btnKQHKTheoLop.Image = global::app.Properties.Resources.xeploai;
            this.btnKQHKTheoLop.ImagePaddingHorizontal = 8;
            this.btnKQHKTheoLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKQHKTheoLop.Name = "btnKQHKTheoLop";
            this.btnKQHKTheoLop.SplitButton = true;
            this.btnKQHKTheoLop.Text = "<div align=\"center\">Kết quả học kỳ<br/>theo lớp học</div>";
            this.btnKQHKTheoLop.Tooltip = "Kết quả học kỳ theo lớp học";
            this.btnKQHKTheoLop.Click += new System.EventHandler(this.btnKQHKTheoLop_Click);
            // 
            // btnKQHKTheoMon
            // 
            this.btnKQHKTheoMon.Image = global::app.Properties.Resources._6;
            this.btnKQHKTheoMon.ImagePaddingHorizontal = 8;
            this.btnKQHKTheoMon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKQHKTheoMon.Name = "btnKQHKTheoMon";
            this.btnKQHKTheoMon.SplitButton = true;
            this.btnKQHKTheoMon.Text = "<div align=\"center\">Kết quả học kỳ<br/>theo môn học</div>";
            this.btnKQHKTheoMon.Tooltip = "Kết quả học kỳ theo môn học";
            this.btnKQHKTheoMon.Click += new System.EventHandler(this.btnKQHKTheoMon_Click);
            // 
            // ribbonPanelQuyDinh
            // 
            this.ribbonPanelQuyDinh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelQuyDinh, this.btnMenuMain);
            this.ribbonPanelQuyDinh.Controls.Add(this.ribbonBarQuyDinh);
            this.ribbonPanelQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuyDinh.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelQuyDinh.Name = "ribbonPanelQuyDinh";
            this.ribbonPanelQuyDinh.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuyDinh.Size = new System.Drawing.Size(792, 91);
            this.ribbonPanelQuyDinh.TabIndex = 3;
            this.ribbonPanelQuyDinh.Visible = false;
            // 
            // ribbonBarQuyDinh
            // 
            this.ribbonBarQuyDinh.AutoOverflowEnabled = true;
            this.ribbonBarQuyDinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarQuyDinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSiSo,
            this.btnDoTuoi,
            this.btnThangDiem,
            this.btnTruong});
            this.ribbonBarQuyDinh.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarQuyDinh.Name = "ribbonBarQuyDinh";
            this.ribbonBarQuyDinh.Size = new System.Drawing.Size(270, 88);
            this.ribbonBarQuyDinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarQuyDinh.TabIndex = 1;
            this.ribbonBarQuyDinh.Text = "Quy Định Chung";
            // 
            // btnSiSo
            // 
            this.btnSiSo.Image = global::app.Properties.Resources.qdsiso;
            this.btnSiSo.ImagePaddingHorizontal = 8;
            this.btnSiSo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSiSo.Name = "btnSiSo";
            this.btnSiSo.SplitButton = true;
            this.btnSiSo.Text = "<div align=\"center\">Quy định<br/>về sỉ số</div>";
            this.btnSiSo.Tooltip = "Quy định về sỉ số";
            this.btnSiSo.Click += new System.EventHandler(this.btnSiSo_Click);
            // 
            // btnDoTuoi
            // 
            this.btnDoTuoi.Image = global::app.Properties.Resources.arrow;
            this.btnDoTuoi.ImagePaddingHorizontal = 8;
            this.btnDoTuoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDoTuoi.Name = "btnDoTuoi";
            this.btnDoTuoi.SplitButton = true;
            this.btnDoTuoi.Text = "<div align=\"center\">Quy định<br/>về độ tuổi</div>";
            this.btnDoTuoi.Tooltip = "Quy định về độ tuổi";
            this.btnDoTuoi.Click += new System.EventHandler(this.btnDoTuoi_Click);
            // 
            // btnThangDiem
            // 
            this.btnThangDiem.Image = global::app.Properties.Resources.build;
            this.btnThangDiem.ImagePaddingHorizontal = 8;
            this.btnThangDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThangDiem.Name = "btnThangDiem";
            this.btnThangDiem.SplitButton = true;
            this.btnThangDiem.Text = "<div align=\"center\">Quy định<br/>thang điểm</div>";
            this.btnThangDiem.Tooltip = "Quy định về thang điểm";
            this.btnThangDiem.Click += new System.EventHandler(this.btnThangDiem_Click);
            // 
            // btnTruong
            // 
            this.btnTruong.Image = global::app.Properties.Resources._5;
            this.btnTruong.ImagePaddingHorizontal = 8;
            this.btnTruong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTruong.Name = "btnTruong";
            this.btnTruong.SplitButton = true;
            this.btnTruong.Text = "<div align=\"center\">Thông tin<br/>trường học</div>";
            this.btnTruong.Tooltip = "Thông tin trường học";
            this.btnTruong.Click += new System.EventHandler(this.btnTruong_Click);
            // 
            // ribbonPanelQuanLy
            // 
            this.ribbonPanelQuanLy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelQuanLy, this.btnMenuMain);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarGiaoVien);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarHocSinh);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarKetQua);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarMonHoc);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarNamHoc);
            this.ribbonPanelQuanLy.Controls.Add(this.ribbonBarLop);
            this.ribbonPanelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuanLy.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelQuanLy.Name = "ribbonPanelQuanLy";
            this.ribbonPanelQuanLy.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuanLy.Size = new System.Drawing.Size(792, 91);
            this.ribbonPanelQuanLy.TabIndex = 1;
            // 
            // ribbonBarGiaoVien
            // 
            this.ribbonBarGiaoVien.AutoOverflowEnabled = true;
            this.ribbonBarGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGiaoVien,
            this.btnPhanCong});
            this.ribbonBarGiaoVien.Location = new System.Drawing.Point(495, 0);
            this.ribbonBarGiaoVien.Name = "ribbonBarGiaoVien";
            this.ribbonBarGiaoVien.Size = new System.Drawing.Size(90, 88);
            this.ribbonBarGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarGiaoVien.TabIndex = 6;
            this.ribbonBarGiaoVien.Text = "Giáo Viên";
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Image = global::app.Properties.Resources.dsgiaovien;
            this.btnGiaoVien.ImagePaddingHorizontal = 8;
            this.btnGiaoVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.SplitButton = true;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.Tooltip = "Giáo viên";
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Image = global::app.Properties.Resources.namhoc;
            this.btnPhanCong.ImagePaddingHorizontal = 8;
            this.btnPhanCong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.SplitButton = true;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.Tooltip = "Phân công";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // ribbonBarHocSinh
            // 
            this.ribbonBarHocSinh.AutoOverflowEnabled = true;
            this.ribbonBarHocSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarHocSinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocSinh,
            this.btnPhanLop});
            this.ribbonBarHocSinh.Location = new System.Drawing.Point(405, 0);
            this.ribbonBarHocSinh.Name = "ribbonBarHocSinh";
            this.ribbonBarHocSinh.Size = new System.Drawing.Size(90, 88);
            this.ribbonBarHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarHocSinh.TabIndex = 5;
            this.ribbonBarHocSinh.Text = "Học Sinh";
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Image = global::app.Properties.Resources.people;
            this.btnHocSinh.ImagePaddingHorizontal = 8;
            this.btnHocSinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.SplitButton = true;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.Tooltip = "Học sinh";
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.Image = global::app.Properties.Resources.khoilop;
            this.btnPhanLop.ImagePaddingHorizontal = 8;
            this.btnPhanLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.SplitButton = true;
            this.btnPhanLop.Text = "<div align=\"center\">Phân<br />lớp</div>";
            this.btnPhanLop.Tooltip = "Phân lớp";
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // ribbonBarKetQua
            // 
            this.ribbonBarKetQua.AutoOverflowEnabled = true;
            this.ribbonBarKetQua.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarKetQua.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnKetQua,
            this.btnHocLuc,
            this.btnHanhKiem});
            this.ribbonBarKetQua.Location = new System.Drawing.Point(273, 0);
            this.ribbonBarKetQua.Name = "ribbonBarKetQua";
            this.ribbonBarKetQua.Size = new System.Drawing.Size(132, 88);
            this.ribbonBarKetQua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarKetQua.TabIndex = 4;
            this.ribbonBarKetQua.Text = "Kết Quả";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Image = global::app.Properties.Resources.pathing;
            this.btnKetQua.ImagePaddingHorizontal = 8;
            this.btnKetQua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.SplitButton = true;
            this.btnKetQua.Text = "<div align=\"center\">Kết<br/>quả</div>";
            this.btnKetQua.Tooltip = "Kết quả";
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // btnHocLuc
            // 
            this.btnHocLuc.Image = global::app.Properties.Resources.pencil;
            this.btnHocLuc.ImagePaddingHorizontal = 8;
            this.btnHocLuc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocLuc.Name = "btnHocLuc";
            this.btnHocLuc.SplitButton = true;
            this.btnHocLuc.Text = "<div align=\"center\">Học<br/>lực</div>";
            this.btnHocLuc.Tooltip = "Học lực";
            this.btnHocLuc.Click += new System.EventHandler(this.btnHocLuc_Click);
            // 
            // btnHanhKiem
            // 
            this.btnHanhKiem.Image = global::app.Properties.Resources.vault;
            this.btnHanhKiem.ImagePaddingHorizontal = 8;
            this.btnHanhKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHanhKiem.Name = "btnHanhKiem";
            this.btnHanhKiem.SplitButton = true;
            this.btnHanhKiem.Text = "<div align=\"center\">Hạnh<br/>kiểm</div>";
            this.btnHanhKiem.Tooltip = "Hạnh kiểm";
            this.btnHanhKiem.Click += new System.EventHandler(this.btnHanhKiem_Click);
            // 
            // ribbonBarMonHoc
            // 
            this.ribbonBarMonHoc.AutoOverflowEnabled = true;
            this.ribbonBarMonHoc.DialogLauncherVisible = true;
            this.ribbonBarMonHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarMonHoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMonHoc,
            this.btnDiem});
            this.ribbonBarMonHoc.Location = new System.Drawing.Point(183, 0);
            this.ribbonBarMonHoc.Name = "ribbonBarMonHoc";
            this.ribbonBarMonHoc.Size = new System.Drawing.Size(90, 88);
            this.ribbonBarMonHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.superTooltip.SetSuperTooltip(this.ribbonBarMonHoc, new DevComponents.DotNetBar.SuperTooltipInfo("Nhập điểm riêng cho từng học sinh", "Nhấn F1 để biết thêm thông tin về quy trình nhập điểm.", "Chức năng này được mở rộng giúp cho người dùng có thể nhập điểm riêng cho từng họ" +
            "c sinh trong lớp học.", null, global::app.Properties.Resources.help, DevComponents.DotNetBar.eTooltipColor.Office2003));
            this.ribbonBarMonHoc.TabIndex = 3;
            this.ribbonBarMonHoc.Text = "Môn Học";
            this.ribbonBarMonHoc.LaunchDialog += new System.EventHandler(this.ribbonBarMonHoc_LaunchDialog);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Image = global::app.Properties.Resources.phonebook;
            this.btnMonHoc.ImagePaddingHorizontal = 8;
            this.btnMonHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.SplitButton = true;
            this.btnMonHoc.Text = "<div align=\"center\">Môn<br/>học</div>";
            this.btnMonHoc.Tooltip = "Môn học";
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Image = global::app.Properties.Resources.pen;
            this.btnDiem.ImagePaddingHorizontal = 8;
            this.btnDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.SplitButton = true;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.Tooltip = "Nhập điểm cho học sinh";
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // ribbonBarNamHoc
            // 
            this.ribbonBarNamHoc.AutoOverflowEnabled = true;
            this.ribbonBarNamHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarNamHoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocKy,
            this.btnNamHoc});
            this.ribbonBarNamHoc.Location = new System.Drawing.Point(93, 0);
            this.ribbonBarNamHoc.Name = "ribbonBarNamHoc";
            this.ribbonBarNamHoc.Size = new System.Drawing.Size(90, 88);
            this.ribbonBarNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarNamHoc.TabIndex = 2;
            this.ribbonBarNamHoc.Text = "Năm Học";
            // 
            // btnHocKy
            // 
            this.btnHocKy.Image = global::app.Properties.Resources.interact;
            this.btnHocKy.ImagePaddingHorizontal = 8;
            this.btnHocKy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocKy.Name = "btnHocKy";
            this.btnHocKy.SplitButton = true;
            this.btnHocKy.Text = "<div align=\"center\">Học<br/>kỳ</div>";
            this.btnHocKy.Tooltip = "Học kỳ";
            this.btnHocKy.Click += new System.EventHandler(this.btnHocKy_Click);
            // 
            // btnNamHoc
            // 
            this.btnNamHoc.Image = global::app.Properties.Resources.school;
            this.btnNamHoc.ImagePaddingHorizontal = 8;
            this.btnNamHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNamHoc.Name = "btnNamHoc";
            this.btnNamHoc.SplitButton = true;
            this.btnNamHoc.Text = "<div align=\"center\">Năm<br/>học</div>";
            this.btnNamHoc.Tooltip = "Năm học";
            this.btnNamHoc.Click += new System.EventHandler(this.btnNamHoc_Click);
            // 
            // ribbonBarLop
            // 
            this.ribbonBarLop.AutoOverflowEnabled = true;
            this.ribbonBarLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarLop.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLopHoc,
            this.btnKhoiLop});
            this.ribbonBarLop.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarLop.Name = "ribbonBarLop";
            this.ribbonBarLop.Size = new System.Drawing.Size(90, 88);
            this.ribbonBarLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarLop.TabIndex = 1;
            this.ribbonBarLop.Text = "Lớp - Khối Lớp";
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Image = global::app.Properties.Resources._7;
            this.btnLopHoc.ImagePaddingHorizontal = 8;
            this.btnLopHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.SplitButton = true;
            this.btnLopHoc.Text = "<div align=\"center\">Lớp<br/>học</div>";
            this.btnLopHoc.Tooltip = "Lớp học";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnKhoiLop
            // 
            this.btnKhoiLop.Image = global::app.Properties.Resources._8;
            this.btnKhoiLop.ImagePaddingHorizontal = 8;
            this.btnKhoiLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKhoiLop.Name = "btnKhoiLop";
            this.btnKhoiLop.SplitButton = true;
            this.btnKhoiLop.Text = "<div align=\"center\">Khối<br/>lớp</div>";
            this.btnKhoiLop.Tooltip = "Khối lớp";
            this.btnKhoiLop.Click += new System.EventHandler(this.btnKhoiLop_Click);
            // 
            // ribbonPanelTraCuu
            // 
            this.ribbonPanelTraCuu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.SetContextMenuEx(this.ribbonPanelTraCuu, this.btnMenuMain);
            this.ribbonPanelTraCuu.Controls.Add(this.ribbonBarTraCuu);
            this.ribbonPanelTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelTraCuu.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelTraCuu.Name = "ribbonPanelTraCuu";
            this.ribbonPanelTraCuu.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelTraCuu.Size = new System.Drawing.Size(792, 91);
            this.ribbonPanelTraCuu.TabIndex = 4;
            this.ribbonPanelTraCuu.Visible = false;
            // 
            // ribbonBarTraCuu
            // 
            this.ribbonBarTraCuu.AutoOverflowEnabled = true;
            this.ribbonBarTraCuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarTraCuu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimKiemHS,
            this.btnTimKiemGV});
            this.ribbonBarTraCuu.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarTraCuu.Name = "ribbonBarTraCuu";
            this.ribbonBarTraCuu.Size = new System.Drawing.Size(114, 88);
            this.ribbonBarTraCuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBarTraCuu.TabIndex = 1;
            this.ribbonBarTraCuu.Text = "Tra Cứu";
            // 
            // btnTimKiemHS
            // 
            this.btnTimKiemHS.Image = global::app.Properties.Resources.quanlynguoidung;
            this.btnTimKiemHS.ImagePaddingHorizontal = 8;
            this.btnTimKiemHS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiemHS.Name = "btnTimKiemHS";
            this.btnTimKiemHS.SplitButton = true;
            this.btnTimKiemHS.Text = "Học Sinh";
            this.btnTimKiemHS.Tooltip = "Tra cứu học sinh";
            this.btnTimKiemHS.Click += new System.EventHandler(this.btnTimKiemHS_Click);
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.Image = global::app.Properties.Resources.tracuugiaovien;
            this.btnTimKiemGV.ImagePaddingHorizontal = 8;
            this.btnTimKiemGV.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.SplitButton = true;
            this.btnTimKiemGV.Text = "Giáo Viên";
            this.btnTimKiemGV.Tooltip = "Tra cứu giáo viên";
            this.btnTimKiemGV.Click += new System.EventHandler(this.btnTimKiemGV_Click);
            // 
            // ribbonTabQuanLy
            // 
            this.ribbonTabQuanLy.Checked = true;
            this.ribbonTabQuanLy.ImagePaddingHorizontal = 8;
            this.ribbonTabQuanLy.Name = "ribbonTabQuanLy";
            this.ribbonTabQuanLy.Panel = this.ribbonPanelQuanLy;
            this.ribbonTabQuanLy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.ribbonTabQuanLy.Text = "&Quản lý";
            this.ribbonTabQuanLy.Tooltip = "Quản lý (F2)";
            // 
            // ribbonTabThongKe
            // 
            this.ribbonTabThongKe.ImagePaddingHorizontal = 8;
            this.ribbonTabThongKe.Name = "ribbonTabThongKe";
            this.ribbonTabThongKe.Panel = this.ribbonPanelThongKe;
            this.ribbonTabThongKe.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.ribbonTabThongKe.Text = "&Báo cáo - Thống kê";
            this.ribbonTabThongKe.Tooltip = "Thống kê (F3)";
            // 
            // ribbonTabTraCuu
            // 
            this.ribbonTabTraCuu.ImagePaddingHorizontal = 8;
            this.ribbonTabTraCuu.Name = "ribbonTabTraCuu";
            this.ribbonTabTraCuu.Panel = this.ribbonPanelTraCuu;
            this.ribbonTabTraCuu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.ribbonTabTraCuu.Text = "Tìm kiếm";
            this.ribbonTabTraCuu.Tooltip = "Tra cứu (F4)";
            // 
            // ribbonTabQuyDinh
            // 
            this.ribbonTabQuyDinh.ImagePaddingHorizontal = 8;
            this.ribbonTabQuyDinh.Name = "ribbonTabQuyDinh";
            this.ribbonTabQuyDinh.Panel = this.ribbonPanelQuyDinh;
            this.ribbonTabQuyDinh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.ribbonTabQuyDinh.Text = "&Quy định";
            this.ribbonTabQuyDinh.Tooltip = "Quy định (F5)";
            this.ribbonTabQuyDinh.Click += new System.EventHandler(this.RibbonTabQuyDinh_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.AutoExpandOnClick = true;
            this.buttonFile.CanCustomize = false;
            this.buttonFile.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile.Image = global::app.Properties.Resources.lophoc;
            this.buttonFile.ImagePaddingHorizontal = 2;
            this.buttonFile.ImagePaddingVertical = 2;
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.ShowSubItems = false;
            this.buttonFile.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileContainer});
            this.buttonFile.Text = "F&ile";
            this.buttonFile.Tooltip = "Nút điều khiển chương trình";
            // 
            // menuFileContainer
            // 
            // 
            // 
            // 
            this.menuFileContainer.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.menuFileContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileContainer.Name = "menuFileContainer";
            this.menuFileContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.menuFileItems});
            // 
            // menuFileItems
            // 
            // 
            // 
            // 
            this.menuFileItems.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.menuFileItems.ItemSpacing = 5;
            this.menuFileItems.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.menuFileItems.MinimumSize = new System.Drawing.Size(120, 0);
            this.menuFileItems.Name = "menuFileItems";
            this.menuFileItems.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnQLNguoiDung,
            this.btnThoat});
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangNhap.Image = global::app.Properties.Resources.dangnhap;
            this.btnDangNhap.ImagePaddingHorizontal = 8;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.SubItemsExpandWidth = 24;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangXuat.Image = global::app.Properties.Resources.dangxuat;
            this.btnDangXuat.ImagePaddingHorizontal = 8;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SubItemsExpandWidth = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLNguoiDung.Image = global::app.Properties.Resources.quanlynguoidung;
            this.btnQLNguoiDung.ImagePaddingHorizontal = 8;
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.SubItemsExpandWidth = 24;
            this.btnQLNguoiDung.Text = "Quản lý người dùng";
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThoat.Image = global::app.Properties.Resources.thoat;
            this.btnThoat.ImagePaddingHorizontal = 8;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SubItemsExpandWidth = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // qatCustomizeItem
            // 
            this.qatCustomizeItem.Name = "qatCustomizeItem";
            this.qatCustomizeItem.Tooltip = "Thanh công cụ truy xuất nhanh";
            // 
            // ribbonTabItemGroup
            // 
            this.ribbonTabItemGroup.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange;
            this.ribbonTabItemGroup.GroupTitle = "Tab Group";
            this.ribbonTabItemGroup.Name = "ribbonTabItemGroup";
            // 
            // 
            // 
            this.ribbonTabItemGroup.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.ribbonTabItemGroup.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.ribbonTabItemGroup.Style.BackColorGradientAngle = 90;
            this.ribbonTabItemGroup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderBottomWidth = 1;
            this.ribbonTabItemGroup.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ribbonTabItemGroup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderLeftWidth = 1;
            this.ribbonTabItemGroup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderRightWidth = 1;
            this.ribbonTabItemGroup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup.Style.BorderTopWidth = 1;
            this.ribbonTabItemGroup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonTabItemGroup.Style.TextColor = System.Drawing.Color.Black;
            this.ribbonTabItemGroup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // bottomBar
            // 
            this.bottomBar.AccessibleDescription = "DotNetBar Bar (bottomBar)";
            this.bottomBar.AccessibleName = "DotNetBar Bar";
            this.bottomBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bottomBar.AlwaysDisplayDockTab = true;
            this.bottomBar.AntiAlias = true;
            this.bottomBar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.ctxMenuMain.SetContextMenuEx(this.bottomBar, this.btnMenuMain);
            this.bottomBar.Controls.Add(this.lblTenNguoiDung);
            this.bottomBar.Controls.Add(this.lblNguoiDung);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bottomBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bottomBar.ItemSpacing = 2;
            this.bottomBar.Location = new System.Drawing.Point(4, 531);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.SingleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bottomBar.Size = new System.Drawing.Size(792, 25);
            this.bottomBar.Stretch = true;
            this.bottomBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bottomBar.TabIndex = 7;
            this.bottomBar.TabStop = false;
            this.bottomBar.Text = "barStatus";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Red;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(145, 5);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(0, 0);
            this.lblTenNguoiDung.TabIndex = 0;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNguoiDung.Location = new System.Drawing.Point(0, 5);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(144, 15);
            this.lblNguoiDung.TabIndex = 0;
            this.lblNguoiDung.Text = "Người dùng đang đăng nhập:";
            // 
            // tabStrip
            // 
            this.tabStrip.AutoSelectAttachedControl = true;
            this.tabStrip.CanReorderTabs = true;
            this.tabStrip.CloseButtonOnTabsVisible = true;
            this.tabStrip.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip.CloseButtonVisible = false;
            this.ctxMenuMain.SetContextMenuEx(this.tabStrip, this.btnMenuMain);
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip.Location = new System.Drawing.Point(4, 150);
            this.tabStrip.MdiForm = this;
            this.tabStrip.MdiTabbedDocuments = true;
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedTab = null;
            this.tabStrip.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip.Size = new System.Drawing.Size(792, 26);
            this.tabStrip.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip.TabIndex = 1;
            this.tabStrip.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip.Text = "tabStrip";
            // 
            // mdiClient
            // 
            this.mdiClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.mdiClient.BackgroundImage = global::app.Properties.Resources.background;
            this.mdiClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mdiClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdiClient.Location = new System.Drawing.Point(4, 176);
            this.mdiClient.Name = "mdiClient";
            this.mdiClient.Size = new System.Drawing.Size(792, 355);
            this.mdiClient.TabIndex = 2;
            // 
            // ctxMenuMain
            // 
            this.ctxMenuMain.AntiAlias = true;
            this.ctxMenuMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenuMain});
            this.ctxMenuMain.Location = new System.Drawing.Point(363, 267);
            this.ctxMenuMain.Name = "ctxMenuMain";
            this.ctxMenuMain.Size = new System.Drawing.Size(75, 25);
            this.ctxMenuMain.Stretch = true;
            this.ctxMenuMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenuMain.TabIndex = 8;
            this.ctxMenuMain.TabStop = false;
            this.ctxMenuMain.Text = "ctxMenu";
            // 
            // btnMenuMain
            // 
            this.btnMenuMain.AutoExpandOnClick = true;
            this.btnMenuMain.ImagePaddingHorizontal = 8;
            this.btnMenuMain.Name = "btnMenuMain";
            this.btnMenuMain.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenuMain.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhapContext,
            this.btnDangXuatContext,
            this.btnThoatContext});
            this.btnMenuMain.Text = "Menu";
            // 
            // btnDangNhapContext
            // 
            this.btnDangNhapContext.Image = global::app.Properties.Resources.dangnhapcontext;
            this.btnDangNhapContext.ImagePaddingHorizontal = 8;
            this.btnDangNhapContext.Name = "btnDangNhapContext";
            this.btnDangNhapContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL);
            this.btnDangNhapContext.Text = "Đăng nhập";
            this.btnDangNhapContext.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuatContext
            // 
            this.btnDangXuatContext.Image = global::app.Properties.Resources.dangxuatcontext;
            this.btnDangXuatContext.ImagePaddingHorizontal = 8;
            this.btnDangXuatContext.Name = "btnDangXuatContext";
            this.btnDangXuatContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.btnDangXuatContext.Text = "Đăng xuất hệ thống";
            this.btnDangXuatContext.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoatContext
            // 
            this.btnThoatContext.Image = global::app.Properties.Resources.exit;
            this.btnThoatContext.ImagePaddingHorizontal = 8;
            this.btnThoatContext.Name = "btnThoatContext";
            this.btnThoatContext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnThoatContext.Text = "Thoát chương trình";
            this.btnThoatContext.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "app";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "app.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "app.chm";
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(205)))), ((int)(((byte)(214)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.ctxMenuMain);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.mdiClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN SỰ TRƯỜNG HỌC";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanelThongKe.ResumeLayout(false);
            this.ribbonPanelQuyDinh.ResumeLayout(false);
            this.ribbonPanelQuanLy.ResumeLayout(false);
            this.ribbonPanelTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.bottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenuMain)).EndInit();
            this.ResumeLayout(false);

        }

        

        //Components
        private System.Windows.Forms.MdiClient mdiClient;
        private System.Windows.Forms.SaveFileDialog backupDialog;
        private System.Windows.Forms.OpenFileDialog restoreDialog;
        private System.Windows.Forms.HelpProvider helpProvider;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabThongKe;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuyDinh;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelQuanLy;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelThongKe;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelQuyDinh;
        private DevComponents.DotNetBar.ItemContainer menuFileContainer;
        private DevComponents.DotNetBar.Office2007StartButton buttonFile;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarLop;
        private DevComponents.DotNetBar.ButtonItem btnLopHoc;
        private DevComponents.DotNetBar.RibbonBar ribbonBarKQHocKy;
        private DevComponents.DotNetBar.ButtonItem btnKQHKTheoLop;
        private DevComponents.DotNetBar.RibbonBar ribbonBarQuyDinh;
        private DevComponents.DotNetBar.ButtonItem btnDoTuoi;
        private DevComponents.DotNetBar.RibbonTabItemGroup ribbonTabItemGroup;
        private DevComponents.DotNetBar.Bar bottomBar;
        private DevComponents.DotNetBar.ButtonItem btnKhoiLop;
        private DevComponents.DotNetBar.RibbonBar ribbonBarKetQua;
        private DevComponents.DotNetBar.ButtonItem btnKetQua;
        private DevComponents.DotNetBar.RibbonBar ribbonBarMonHoc;
        private DevComponents.DotNetBar.ButtonItem btnMonHoc;
        private DevComponents.DotNetBar.ButtonItem btnDiem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarNamHoc;
        private DevComponents.DotNetBar.ButtonItem btnHocKy;
        private DevComponents.DotNetBar.ButtonItem btnNamHoc;
        private DevComponents.DotNetBar.RibbonBar ribbonBarHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnPhanLop;
        private DevComponents.DotNetBar.RibbonBar ribbonBarGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnPhanCong;
        private DevComponents.DotNetBar.ButtonItem btnSiSo;
        private DevComponents.DotNetBar.ButtonItem btnThangDiem;
        private DevComponents.DotNetBar.ButtonItem btnTruong;
        private DevComponents.DotNetBar.ButtonItem btnKQHKTheoMon;
        private DevComponents.DotNetBar.RibbonBar ribbonBarKQCuoiNam;
        private DevComponents.DotNetBar.TabStrip tabStrip;
        private DevComponents.DotNetBar.ButtonItem btnHocLuc;
        private DevComponents.DotNetBar.ButtonItem btnHanhKiem;
        private DevComponents.DotNetBar.ItemContainer menuFileItems;
        private DevComponents.DotNetBar.ButtonItem btnDangNhap;
        private DevComponents.DotNetBar.ButtonItem btnDangXuat;
        private DevComponents.DotNetBar.ButtonItem btnQLNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.LabelX lblNguoiDung;
        private DevComponents.DotNetBar.RibbonBar ribbonBarXuatDanhSach;
        private DevComponents.DotNetBar.ButtonItem btnDanhSachHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnDanhSachGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnDanhSachLopHoc;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenuMain;
        private DevComponents.DotNetBar.ButtonItem btnMenuMain;
        private DevComponents.DotNetBar.ButtonItem btnDangNhapContext;
        private DevComponents.DotNetBar.ButtonItem btnDangXuatContext;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelTraCuu;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabTraCuu;
        private DevComponents.DotNetBar.RibbonBar ribbonBarTraCuu;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemHS;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemGV;
        private DevComponents.DotNetBar.LabelX lblTenNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnThoatContext;
        private DevComponents.DotNetBar.ButtonItem btnKQCNTheoLop;
        private DevComponents.DotNetBar.ButtonItem btnKQCNTheoMon;
        
    }
}