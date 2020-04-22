using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;

namespace app
{
    public partial class frmAbout : Office2007Form
    {
        //Constructor
        public frmAbout()
        {
            InitializeComponent();
        }
        

        //Load
        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.lbl08Email.Links.Add(0, 19, "mailto:hoangviet.mta.hp@gmail.com");
        }
        

        //Click event
        private void lbl08Email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Hello");
        }

        private void lbl10Website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://"))
                Process.Start(strURL);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}