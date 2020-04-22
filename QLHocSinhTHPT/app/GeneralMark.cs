using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using app.Controller;
using app.Component;
using app.DataLayer;
using DevComponents.DotNetBar;

namespace app
{
    public partial class GeneralMark : Office2007Form
    {
        //Fields
        NamHocCtrl          m_NamHocCtrl            = new NamHocCtrl();
        LopCtrl             m_LopCtrl               = new LopCtrl();
        HocKyCtrl           m_HocKyCtrl             = new HocKyCtrl();
        MonHocCtrl          m_MonHocCtrl            = new MonHocCtrl();
        DiemCtrl            m_DiemCtrl              = new DiemCtrl();
        LoaiDiemCtrl        m_LoaiDiemCtrl          = new LoaiDiemCtrl();
        HocSinhCtrl         m_HocSinhCtrl           = new HocSinhCtrl();
        DiemData            m_DiemData              = new DiemData();
        QuyDinh             quyDinh                 = new QuyDinh();
        int[,] STT = null;
        

        //Constructor
        public GeneralMark()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void GeneralMark_Load(object sender, EventArgs e)
        {
            //Nhập điểm
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);

            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
            

            //Sửa điểm
            m_NamHocCtrl.HienThiComboBox(cmbNamHocSD);
            m_HocKyCtrl.HienThiComboBox(cmbHocKySD);
            if (cmbNamHocSD.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHocSD.SelectedValue.ToString(), cmbLopSD);

            if (cmbNamHocSD.SelectedValue != null && cmbLopSD.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHocSD.SelectedValue.ToString(), cmbLopSD.SelectedValue.ToString(), cmbMonHocSD);
            
        }
        

        //BindingNavigatorItems
        //Kiểm tra điểm số trước khi lưu
        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dGVDiem.Rows)
            {
                if (row.Cells[loaiDiem].Value != null)
                {
                    String chuoiDiemChuaXuLy = row.Cells[loaiDiem].Value.ToString();
                    String diemDaXuLy = null;

                    int count = 0;
                    for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                    {
                        if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                            count++;
                        else
                        {
                            if (i == chuoiDiemChuaXuLy.Length - 1)
                            {
                                i++;
                                count++;
                            }

                            diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                            if (count != 0 && quyDinh.KiemTraDiem(diemDaXuLy) == false)
                            {
                                MessageBoxEx.Show("Điểm của học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            diemDaXuLy = null;
                            count = 0;
                        }
                    }
                }
            }
            return true;
        }
        

        //Lưu điểm
        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (KiemTraDiemTruocKhiLuu("colDiemMieng")  == true &&
                KiemTraDiemTruocKhiLuu("colDiem15Phut") == true &&
                KiemTraDiemTruocKhiLuu("colDiem45Phut") == true &&
                KiemTraDiemTruocKhiLuu("colDiemThi")    == true)
            {
                //Nếu nhập điểm
                if (buttonItemNhapDuLieu.Checked == true )
                {
                    int rowcount = 0;

                    foreach (DataGridViewRow row in dGVDiem.Rows)
                    {
                        rowcount++;

                        //Kiểm tra miệng
                        if (row.Cells["colDiemMieng"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["colDiemMieng"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHoc.SelectedValue.ToString(),
                                                           cmbHocKy.SelectedValue.ToString(),
                                                           cmbNamHoc.SelectedValue.ToString(),
                                                           cmbLop.SelectedValue.ToString(),
                                                           "LD0001",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        

                        //Kiểm tra 15 phút
                        if (row.Cells["colDiem15Phut"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["colDiem15Phut"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHoc.SelectedValue.ToString(),
                                                           cmbHocKy.SelectedValue.ToString(),
                                                           cmbNamHoc.SelectedValue.ToString(),
                                                           cmbLop.SelectedValue.ToString(),
                                                           "LD0002",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        

                        //Kiểm tra 45 phút
                        if (row.Cells["colDiem45Phut"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["colDiem45Phut"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHoc.SelectedValue.ToString(),
                                                           cmbHocKy.SelectedValue.ToString(),
                                                           cmbNamHoc.SelectedValue.ToString(),
                                                           cmbLop.SelectedValue.ToString(),
                                                           "LD0003",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        

                        //Thi học kỳ
                        if (row.Cells["colDiemThi"].Value != null)
                        {
                            String diemThi = row.Cells["colDiemThi"].Value.ToString();
                            if (quyDinh.KiemTraDiem(diemThi))
                                m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHoc.SelectedValue.ToString(),
                                                           cmbHocKy.SelectedValue.ToString(),
                                                           cmbNamHoc.SelectedValue.ToString(),
                                                           cmbLop.SelectedValue.ToString(),
                                                           "LD0004",
                                                           float.Parse(diemThi.ToString()));
                        }
                        
                    }
                    MessageBoxEx.Show("Đã lưu thành công vào bảng điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

                //Nếu sửa điểm
                if (buttonItemCapNhatDuLieu.Checked == true )
                {
                    int rowcount = 0;

                    foreach (DataGridViewRow row in dGVDiem.Rows)
                    {
                        rowcount++;

                        //Kiểm tra miệng
                        if (row.Cells["colDiemMieng"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["colDiemMieng"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.CapNhatDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHocSD.SelectedValue.ToString(),
                                                           cmbHocKySD.SelectedValue.ToString(),
                                                           cmbNamHocSD.SelectedValue.ToString(),
                                                           cmbLopSD.SelectedValue.ToString(),
                                                           "LD0001",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        

                        //Kiểm tra 15 phút
                        if (row.Cells["colDiem15Phut"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["colDiem15Phut"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.CapNhatDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHocSD.SelectedValue.ToString(),
                                                           cmbHocKySD.SelectedValue.ToString(),
                                                           cmbNamHocSD.SelectedValue.ToString(),
                                                           cmbLopSD.SelectedValue.ToString(),
                                                           "LD0002",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        

                        //Kiểm tra 45 phút
                        if (row.Cells["colDiem45Phut"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["colDiem45Phut"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.CapNhatDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHocSD.SelectedValue.ToString(),
                                                           cmbHocKySD.SelectedValue.ToString(),
                                                           cmbNamHocSD.SelectedValue.ToString(),
                                                           cmbLopSD.SelectedValue.ToString(),
                                                           "LD0003",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        

                        //Thi học kỳ
                        if (row.Cells["colDiemThi"].Value != null)
                        {
                            String diemThi = row.Cells["colDiemThi"].Value.ToString();
                            if (quyDinh.KiemTraDiem(diemThi))
                                m_DiemCtrl.CapNhatDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                                           cmbMonHocSD.SelectedValue.ToString(),
                                                           cmbHocKySD.SelectedValue.ToString(),
                                                           cmbNamHocSD.SelectedValue.ToString(),
                                                           cmbLopSD.SelectedValue.ToString(),
                                                           "LD0004",
                                                           float.Parse(diemThi.ToString()));
                        }
                        

                        //Xóa các kết quả cũ
                        if (STT != null)
                        {
                            for (int i = 1; i < 60; i++)
                                for (int j = 1; j < 20; j++)
                                {
                                    int id = STT[i, j];
                                    if (id > 0)
                                        m_DiemCtrl.XoaDiem(id);
                                    else
                                        break;
                                }
                        }
                        
                    }
                    MessageBoxEx.Show("Cập nhật thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
        

        //Xem điểm
        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormXemDiem();
        }
        

        //Thoát khỏi form nhập điểm
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

        //DataError event
        private void dGVNhapDiemChung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        

        //Click event nhập điểm
        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNamHoc();
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLopHoc();
            m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocKy();
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
            m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocKy.SelectedValue != null && cmbMonHoc.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dGVDiem, bindingNavigatorDiem, cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());
        }
        

        //Click event sửa điểm
        private void btnHienThiDanhSachSD_Click(object sender, EventArgs e)
        {
            STT = new int[60, 20];

            if (cmbNamHocSD.SelectedValue != null && cmbLopSD.SelectedValue != null && cmbHocKySD.SelectedValue != null && cmbMonHocSD.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dGVDiem, bindingNavigatorDiem, cmbNamHocSD.SelectedValue.ToString(), cmbLopSD.SelectedValue.ToString());

            int countRowHocSinh = 0;
            foreach (DataGridViewRow rowHocSinh in dGVDiem.Rows)
            {
                countRowHocSinh++;

                String[] diemMieng = new String[10];
                String[] diem15Phut = new String[10];
                String[] diem45Phut = new String[10];
                String diemThi = "";

                int soDiemMieng = 0;
                int soDiem15Phut = 0;
                int soDiem45Phut = 0;

                DataTable m_DT = m_DiemData.LayDsDiem(rowHocSinh.Cells["colMaHocSinh"].Value.ToString(),
                                                      cmbMonHocSD.SelectedValue.ToString(),
                                                      cmbHocKySD.SelectedValue.ToString(),
                                                      cmbNamHocSD.SelectedValue.ToString(),
                                                      cmbLopSD.SelectedValue.ToString());

                int countRowDiem = 0;
                foreach (DataRow rowDiem in m_DT.Rows)
                {
                    countRowDiem++;

                    STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());

                    if (rowDiem["MaLoai"].ToString() == "LD0001")
                        diemMieng[soDiemMieng++] = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoai"].ToString() == "LD0002")
                        diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoai"].ToString() == "LD0003")
                        diem45Phut[soDiem45Phut++] = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoai"].ToString() == "LD0004")
                        diemThi = rowDiem["Diem"].ToString();
                }

                rowHocSinh.Cells["colDiemMieng"].Value = quyDinh.ArrayToString(diemMieng, soDiemMieng);
                rowHocSinh.Cells["colDiem15Phut"].Value = quyDinh.ArrayToString(diem15Phut, soDiem15Phut);
                rowHocSinh.Cells["colDiem45Phut"].Value = quyDinh.ArrayToString(diem45Phut, soDiem45Phut);
                rowHocSinh.Cells["colDiemThi"].Value = diemThi;
            }
        }
        

        //SelectedIndexChanged event nhập điểm
        //Lấy thông tin lớp theo từng năm học
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        //Lấy môn học theo từng lớp
        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
            cmbMonHoc.DataBindings.Clear();
        }
        

        //SelectedIndexChanged event sửa điểm
        //Lấy thông tin lớp theo từng năm học
        private void cmbNamHocSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocSD.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHocSD.SelectedValue.ToString(), cmbLopSD);
            cmbLopSD.DataBindings.Clear();
        }

        //Lấy môn học theo từng lớp
        private void cmbLopSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocSD.SelectedValue != null && cmbLopSD.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHocSD.SelectedValue.ToString(), cmbLopSD.SelectedValue.ToString(), cmbMonHocSD);
            cmbMonHocSD.DataBindings.Clear();
        }
        

        private void NavPaneLeft_Load(object sender, EventArgs e)
        {

        }

        private void ButtonItemCapNhatDuLieu_Click(object sender, EventArgs e)
        {

        }

        private void dGVDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}