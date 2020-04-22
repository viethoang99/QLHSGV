using System;
using System.Text;
using System.Drawing;
using app.init;
using app.Component;
using app.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace app.Reports
{
    public partial class frptKetQuaCaNam_Lop : Office2007Form
    {
        //Fields
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        

        //Constructor
        public frptKetQuaCaNam_Lop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void frptKetQuaCaNam_Lop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }
        

        //SelectedIndexChanged event
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }
        

        //Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.SelectedValue.ToString()));
            param.Add(new ReportParameter("Lop", cmbLop.SelectedValue.ToString()));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerKQCNTH.LocalReport.SetParameters(param);

            IList<KQCaNamTongHopInfo> KQCNTH =
              KQCaNamTongHopCtrl.LayDsKQCaNamTongHop(cmbLop.SelectedValue.ToString(),cmbNamHoc.SelectedValue.ToString());
            this.bSKQCNTH.DataSource = KQCNTH;
            this.reportViewerKQCNTH.RefreshReport();
        }
        
    }
}