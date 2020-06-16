using System;
using System.Text;
using System.Drawing;
using app.DataTranferObject;
using app.Component;
using app.BusinessLayer;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace app.Reports
{
    public partial class frptDanhSachLopHoc : Office2007Form
    {
        //Field
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        

        //Constructor
        public frptDanhSachLopHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void frptDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
        }
        

        //Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<LopInfo> lop = LopCtrl.LayDsLop(cmbNamHoc.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            this.reportViewerDSLop.LocalReport.SetParameters(param);

            this.bSDSLop.DataSource = lop;
            this.reportViewerDSLop.RefreshReport();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            IList<LopInfo> lop = LopCtrl.LayDsLop();
       
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", "Tất cả"));
            this.reportViewerDSLop.LocalReport.SetParameters(param);

            this.bSDSLop.DataSource = lop;
            this.reportViewerDSLop.RefreshReport();
        }
        
    }
}