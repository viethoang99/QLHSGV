﻿using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace app.Component
{
    public partial class frmConnection : Office2007Form
    {
        //Constructor
        public frmConnection()
        {
            InitializeComponent();
        }
        

        //Load
        private void frmConnection_Load(object sender, EventArgs e)
        {
            cmbAuthentication.SelectedIndex = 0;
        }
        

        //Click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
                XML.XMLWriter("Connection.xml", txtServer.Text, cmbDatabase.Text, "true");
            else
                XML.XMLWriter("Connection.xml", txtServer.Text, txtUsername.Text, txtPassword.Text, cmbDatabase.Text, "false");

            this.DialogResult = DialogResult.OK;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //Quyền Windows
            if (cmbAuthentication.SelectedIndex == 0)
            {
                cmbDatabase.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;
                
                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    if (String.Compare(txtServer.Text, "") > 0)
                        MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBoxEx.Show("Lỗi kết nối", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException sqlEx)
                {
                    MessageBoxEx.Show(sqlEx.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cmbAuthentication.SelectedIndex == 1)
            {
                cmbDatabase.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;
                
                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    if (String.Compare(txtServer.Text, "") == 0)
                        MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBoxEx.Show("Lỗi kết nối", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException sqlEx)
                {
                    MessageBoxEx.Show(sqlEx.Message, "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }
        

        //SelectedIndexChanged event
        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
        
    }
}