using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Crusader
{
    public partial class ResourceSearch : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;

        public ResourceSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string ResourceName = txtResourceName.Text;
                string Type = txtType.Text;
                string Usage = txtUsage.Text;
                string Acquisition = txtAcquisition.Text;
                string order = "SELECT * FROM Crusader.Resource r WHERE ";
                q = "";
                if (ResourceName != "") { q = q + "r.ResourceName LIKE '%" + ResourceName + "%' AND "; }
                if (Type != "") { q = q + "r.Type LIKE '%" + Type + "%' AND "; }
                if (Usage != "") { q = q + "r.Usage LIKE '%" + Usage + "%' AND "; }
                if (Acquisition != "") { q = q + "r.Acquisition LIKE '%" + Acquisition + "%' AND "; }
                order = order + q.Remove(q.Length - 4, 3);
                SqlCommand cmd = new SqlCommand(order, conn);
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                a.SelectCommand = cmd;
                a.Fill(dt);
                results.DataSource = dt;
                results.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty Input");
            }
            conn.Close();
        }

        private void ResourceSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zhengruiDataSet4.Resource' table. You can move, or remove it, as needed.
            this.resourceTableAdapter.Fill(this.zhengruiDataSet4.Resource);
            conn = new SqlConnection(conn_string);
        }
    }
}
