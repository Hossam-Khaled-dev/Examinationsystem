using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crystalReport
{
    public partial class frmReport4 : Form
    {
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter adapter;
        DataTable DT;
        public frmReport4()
        {
            InitializeComponent();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=DESKTOP-P84ETB9\\MSSQLSERVER01;Initial Catalog=ExamProject; " +
                "Integrated Security = true ; TrustServerCertificate=true ";
            sqlCmd = new SqlCommand("topicsINCourse", SqlCN);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@crs_id", textBox1.Text);
            adapter = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();
            adapter.Fill(DT);

            ReportDocument rdc = new ReportDocument();
            rdc.Load(@"CrystalReport4.rpt");
            rdc.SetDataSource(DT);
            crystalReportViewer1.ReportSource = rdc;
        }
    }
}
