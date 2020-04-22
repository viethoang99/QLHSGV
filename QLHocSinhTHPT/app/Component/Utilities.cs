using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using app.init;
using app.Reports;
using app.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;

namespace app.Component
{
    //Utilities
    public static class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    

    //QuyDinh
    public class QuyDinh
    {
        public static QuyDinhInfo LayThongTinTruong()
        {
            QuyDinhInfo m_Truong = new QuyDinhInfo();
            DataService dS = new DataService();

            dS.Load(new SqlCommand("SELECT TenTruong, DiaChiTruong FROM QUYDINH"));

            if (dS.Rows.Count > 0)
            {
                m_Truong.TenTruong = dS.Rows[0]["TenTruong"].ToString();
                m_Truong.DiaChiTruong = dS.Rows[0]["DiaChiTruong"].ToString();
            }

            return m_Truong;
        }

        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT ThangDiem FROM QUYDINH"));

            int thangDiem = Convert.ToInt32(dS.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
        }

        public Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH"));

            int siSoMin = Convert.ToInt32(dS.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dS.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax)
                return true;
            else
                return false;
        }

        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);

            int doTuoi    = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
    

    //ThamSo
    public static class ThamSo
    {
        //Fields
        public static frmAbout                  m_FrmAbout              = null;
        public static frmConnection             m_FrmConnection         = null;
        public static TeachersFrom               m_TeachersFrom           = null;
        public static ConductForm               m_ConductForm           = null;
        public static TermForm                  m_TermForm              = null;
        public static PerformanceForm                 m_PerformanceForm             = null;
        public static StudentsForm                m_StudentsForm            = null;
        public static Results                 m_Results             = null;
        public static Grades                m_Grades            = null;
        public static Classes                    m_Classes                = null;
        public static MainForm                   m_MainForm               = null;
        public static Subjects                 m_Subjects             = null;
        public static SchoolYear                 m_SchoolYear             = null;
        public static PrivateMark          m_PrivateMark      = null;
        public static GeneralMark          m_GeneralMark      = null;
        public static Mark                m_Mark            = null;
        public static Assigning               m_Assigning           = null;
        public static ClassDivision                m_ClassDivision            = null;
        public static UsersType          m_UsersType      = null;
        public static MarkTypes               m_MarkTypes           = null;
        public static searchTeachers              m_TimKiemGV             = null;
        public static searchStudents              m_TimKiemHS             = null;
        public static frmQuyDinh                m_FrmQuyDinh            = null;
        public static frptDanhSachGiaoVien      m_FrmDSGiaoVien         = null;
        public static frptDanhSachHocSinh       m_FrmDSHocSinh          = null;
        public static frptDanhSachLopHoc        m_FrmDSLopHoc           = null;
        public static frptKetQuaCaNam_Lop       m_ResultsCaNam_Lop    = null;
        public static frptKetQuaCaNam_MonHoc    m_ResultsCaNam_MonHoc = null;
        public static frptKetQuaHocKy_Lop       m_ResultsHocKy_Lop    = null;
        public static frptKetQuaHocKy_MonHoc    m_ResultsHocKy_MonHoc = null;
        

        //Ham goi hien form
        //Menu start
        public static void ShowFormLoaiNguoiDung()
        {
            if (m_UsersType == null || m_UsersType.IsDisposed)
            {
                m_UsersType = new UsersType();
                m_UsersType.MdiParent = MainForm.ActiveForm;
                m_UsersType.Show();
            }
            else
                m_UsersType.Activate();
        }
        

        //Menu quan ly
        public static void ShowFormLopHoc()
        {
            if (m_Classes == null || m_Classes.IsDisposed)
            {
                m_Classes = new Classes();
                m_Classes.MdiParent = MainForm.ActiveForm;
                m_Classes.Show();
            }
            else
                m_Classes.Activate();
        }

        public static void ShowFormKhoiLop()
        {
            if (m_Grades == null || m_Grades.IsDisposed)
            {
                m_Grades = new Grades();
                m_Grades.MdiParent = MainForm.ActiveForm;
                m_Grades.Show();
            }
            else
                m_Grades.Activate();
        }

        public static void ShowFormHocKy()
        {
            if (m_TermForm == null || m_TermForm.IsDisposed)
            {
                m_TermForm = new TermForm();
                m_TermForm.MdiParent = MainForm.ActiveForm;
                m_TermForm.Show();
            }
            else
                m_TermForm.Activate();
        }

        public static void ShowFormNamHoc()
        {
            if (m_SchoolYear == null || m_SchoolYear.IsDisposed)
            {
                m_SchoolYear = new SchoolYear();
                m_SchoolYear.MdiParent = MainForm.ActiveForm;
                m_SchoolYear.Show();
            }
            else
                m_SchoolYear.Activate();
        }

        public static void ShowFormMonHoc()
        {
            if (m_Subjects == null || m_Subjects.IsDisposed)
            {
                m_Subjects = new Subjects();
                m_Subjects.MdiParent = MainForm.ActiveForm;
                m_Subjects.Show();
            }
            else
                m_Subjects.Activate();
        }

        public static void ShowFormLoaiDiem()
        {
            if (m_MarkTypes == null || m_MarkTypes.IsDisposed)
            {
                m_MarkTypes = new MarkTypes();
                m_MarkTypes.MdiParent = MainForm.ActiveForm;
                m_MarkTypes.Show();
            }
            else
                m_MarkTypes.Activate();
        }

        public static void ShowFormNhapDiemRieng()
        {
            if (m_PrivateMark == null || m_PrivateMark.IsDisposed)
            {
                m_PrivateMark = new PrivateMark();
                m_PrivateMark.MdiParent = MainForm.ActiveForm;
                m_PrivateMark.Show();
            }
            else
                m_PrivateMark.Activate();
        }

        public static void ShowFormNhapDiemChung()
        {
            if (m_GeneralMark == null || m_GeneralMark.IsDisposed)
            {
                m_GeneralMark = new GeneralMark();
                m_GeneralMark.MdiParent = MainForm.ActiveForm;
                m_GeneralMark.Show();
            }
            else
                m_GeneralMark.Activate();
        }

        public static void ShowFormXemDiem()
        {
            if (m_Mark == null || m_Mark.IsDisposed)
            {
                m_Mark = new Mark();
                m_Mark.MdiParent = MainForm.ActiveForm;
                m_Mark.Show();
            }
            else
                m_Mark.Activate();
        }

        public static void ShowFormKetQua()
        {
            if (m_Results == null || m_Results.IsDisposed)
            {
                m_Results = new Results();
                m_Results.MdiParent = MainForm.ActiveForm;
                m_Results.Show();
            }
            else
                m_Results.Activate();
        }

        public static void ShowFormHocLuc()
        {
            if (m_PerformanceForm == null || m_PerformanceForm.IsDisposed)
            {
                m_PerformanceForm = new PerformanceForm();
                m_PerformanceForm.MdiParent = MainForm.ActiveForm;
                m_PerformanceForm.Show();
            }
            else
                m_PerformanceForm.Activate();
        }

        public static void ShowFormHanhKiem()
        {
            if (m_ConductForm == null || m_ConductForm.IsDisposed)
            {
                m_ConductForm = new ConductForm();
                m_ConductForm.MdiParent = MainForm.ActiveForm;
                m_ConductForm.Show();
            }
            else
                m_ConductForm.Activate();
        }

        public static void ShowFormHocSinh()
        {
            if (m_StudentsForm == null || m_StudentsForm.IsDisposed)
            {
                m_StudentsForm = new StudentsForm();
                m_StudentsForm.MdiParent = MainForm.ActiveForm;
                m_StudentsForm.Show();
            }
            else
                m_StudentsForm.Activate();
        }

        public static void ShowFormPhanLop()
        {
            if (m_ClassDivision == null || m_ClassDivision.IsDisposed)
            {
                m_ClassDivision = new ClassDivision();
                m_ClassDivision.MdiParent = MainForm.ActiveForm;
                m_ClassDivision.Show();
            }
            else
                m_ClassDivision.Activate();
        }

        public static void ShowFormGiaoVien()
        {
            if (m_TeachersFrom == null || m_TeachersFrom.IsDisposed)
            {
                m_TeachersFrom = new TeachersFrom();
                m_TeachersFrom.MdiParent = MainForm.ActiveForm;
                m_TeachersFrom.Show();
            }
            else
                m_TeachersFrom.Activate();
        }

        public static void ShowFormPhanCong()
        {
            if (m_Assigning == null || m_Assigning.IsDisposed)
            {
                m_Assigning = new Assigning();
                m_Assigning.MdiParent = MainForm.ActiveForm;
                m_Assigning.Show();
            }
            else
                m_Assigning.Activate();
        }
        

        //Menu thong ke
        public static void ShowFormKQHKTheoLop()
        {
            if (m_ResultsHocKy_Lop == null || m_ResultsHocKy_Lop.IsDisposed)
            {
                m_ResultsHocKy_Lop = new frptKetQuaHocKy_Lop();
                m_ResultsHocKy_Lop.MdiParent = MainForm.ActiveForm;
                m_ResultsHocKy_Lop.Show();
            }
            else
                m_ResultsHocKy_Lop.Activate();
        }

        public static void ShowFormKQHKTheoMon()
        {
            if (m_ResultsHocKy_MonHoc == null || m_ResultsHocKy_MonHoc.IsDisposed)
            {
                m_ResultsHocKy_MonHoc = new frptKetQuaHocKy_MonHoc();
                m_ResultsHocKy_MonHoc.MdiParent = MainForm.ActiveForm;
                m_ResultsHocKy_MonHoc.Show();
            }
            else
                m_ResultsHocKy_MonHoc.Activate();
        }

        public static void ShowFormKQCNTheoLop()
        {
            if (m_ResultsCaNam_Lop == null || m_ResultsCaNam_Lop.IsDisposed)
            {
                m_ResultsCaNam_Lop = new frptKetQuaCaNam_Lop();
                m_ResultsCaNam_Lop.MdiParent = MainForm.ActiveForm;
                m_ResultsCaNam_Lop.Show();
            }
            else
                m_ResultsCaNam_Lop.Activate();
        }

        public static void ShowFormKQCNTheoMon()
        {
            if (m_ResultsCaNam_MonHoc == null || m_ResultsCaNam_MonHoc.IsDisposed)
            {
                m_ResultsCaNam_MonHoc = new frptKetQuaCaNam_MonHoc();
                m_ResultsCaNam_MonHoc.MdiParent = MainForm.ActiveForm;
                m_ResultsCaNam_MonHoc.Show();
            }
            else
                m_ResultsCaNam_MonHoc.Activate();
        }

        public static void ShowFormDanhSachHocSinh()
        {
            if (m_FrmDSHocSinh == null || m_FrmDSHocSinh.IsDisposed)
            {
                m_FrmDSHocSinh = new frptDanhSachHocSinh();
                m_FrmDSHocSinh.MdiParent = MainForm.ActiveForm;
                m_FrmDSHocSinh.Show();
            }
            else
                m_FrmDSHocSinh.Activate();
        }

        public static void ShowFormDanhSachGiaoVien()
        {
            if (m_FrmDSGiaoVien == null || m_FrmDSGiaoVien.IsDisposed)
            {
                m_FrmDSGiaoVien = new frptDanhSachGiaoVien();
                m_FrmDSGiaoVien.MdiParent = MainForm.ActiveForm;
                m_FrmDSGiaoVien.Show();
            }
            else
                m_FrmDSGiaoVien.Activate();
        }

        public static void ShowFormDanhSachLopHoc()
        {
            if (m_FrmDSLopHoc == null || m_FrmDSLopHoc.IsDisposed)
            {
                m_FrmDSLopHoc = new frptDanhSachLopHoc();
                m_FrmDSLopHoc.MdiParent = MainForm.ActiveForm;
                m_FrmDSLopHoc.Show();
            }
            else
                m_FrmDSLopHoc.Activate();
        }
        

        //Menu tra cuu
        public static void ShowFormTimKiemHS()
        {
            if (m_TimKiemHS == null || m_TimKiemHS.IsDisposed)
            {
                m_TimKiemHS = new searchStudents();
                m_TimKiemHS.MdiParent = MainForm.ActiveForm;
                m_TimKiemHS.Show();
            }
            else
                m_TimKiemHS.Activate();
        }

        public static void ShowFormTimKiemGV()
        {
            if (m_TimKiemGV == null || m_TimKiemGV.IsDisposed)
            {
                m_TimKiemGV = new searchTeachers();
                m_TimKiemGV.MdiParent = MainForm.ActiveForm;
                m_TimKiemGV.Show();
            }
            else
                m_TimKiemGV.Activate();
        }
        

        //Menu quy dinh
        public static void ShowFormQuyDinh()
        {
            if (m_FrmQuyDinh == null || m_FrmQuyDinh.IsDisposed)
            {
                m_FrmQuyDinh = new frmQuyDinh();
                m_FrmQuyDinh.Show();
            }
            else
                m_FrmQuyDinh.Activate();
        }

        public static void ShowFormKetNoi()
        {
            if (m_FrmConnection == null || m_FrmConnection.IsDisposed)
            {
                m_FrmConnection = new frmConnection();
                m_FrmConnection.Show();
            }
            else
                m_FrmConnection.Activate();
        }
        

        //Menu giup do
        public static void ShowFormThongTin()
        {
            if (m_FrmAbout == null || m_FrmAbout.IsDisposed)
            {
                m_FrmAbout = new frmAbout();
                m_FrmAbout.Show();
            }
            else
                m_FrmAbout.Activate();
        }
        
        
    }
    

    //Các hàm xử lý tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();
            
            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");
            
            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    
}