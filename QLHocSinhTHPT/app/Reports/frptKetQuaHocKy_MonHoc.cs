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
    public partial class frptKetQuaHocKy_MonHoc : Office2007Form
    {
        //Fields
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl   m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        MonHocCtrl  m_MonHocCtrl    = new MonHocCtrl();
        

        //Constructor
        public frptKetQuaHocKy_MonHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void frptKetQuaHocKy_MonHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
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
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
            cmbMonHoc.DataBindings.Clear();
        }
        

        //Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<KQHocKyMonHocInfo> KQHKMH = KQHocKyMonHocCtrl.LayDsKQHocKyMonHoc(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), cmbHocKy.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString());
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.SelectedValue.ToString()));
            param.Add(new ReportParameter("Lop", cmbLop.SelectedValue.ToString()));
            param.Add(new ReportParameter("MonHoc", cmbMonHoc.SelectedValue.ToString()));
            param.Add(new ReportParameter("HocKy", cmbHocKy.SelectedValue.ToString()));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerKQHKMH.LocalReport.SetParameters(param);           
            this.bSKQHKMH.DataSource = KQHKMH;
            this.reportViewerKQHKMH.RefreshReport();
        }
        
    }
}