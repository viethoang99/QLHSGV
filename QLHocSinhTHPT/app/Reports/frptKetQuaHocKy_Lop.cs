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
    public partial class frptKetQuaHocKy_Lop : Office2007Form
    {
        //Fields
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl   m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        

        //Constructor
        public frptKetQuaHocKy_Lop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void frptKetQuaHocKy_Lop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
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
            param.Add(new ReportParameter("HocKy", cmbHocKy.SelectedValue.ToString()));
            param.Add(new ReportParameter("Lop", cmbLop.SelectedValue.ToString()));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerKQHKTH.LocalReport.SetParameters(param);
            IList<KQHocKyTongHopInfo> KQHKTH =
            KQHocKyTongHopCtrl.LayDsKQHocKyTongHop(cmbLop.SelectedValue.ToString(),cmbHocKy.SelectedValue.ToString(),cmbNamHoc.SelectedValue.ToString());
            this.bSKQHKTH.DataSource = KQHKTH;
            this.reportViewerKQHKTH.RefreshReport();
        }
        
    }
}