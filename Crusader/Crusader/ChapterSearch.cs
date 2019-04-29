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
    public partial class ChapterSearch : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;

        public ChapterSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            { 
                conn.Open();
                string Episode = txtEpisode.Text;
                string ChapterName = txtChapterName.Text;
                string Environment = txtEnvironment.Text;
                string Boss = txtBoss.Text;
                string Cost = txtCost.Text;
                string order = "SELECT * FROM Crusader.Chapter c WHERE ";
                q = "";
                if (Episode != "") { q = q + "c.Episode LIKE '%" + Episode + "%' AND "; }
                if (ChapterName != "") { q = q + "c.ChapterName LIKE '%" + ChapterName + "%' AND "; }
                if (Environment != "") { q = q + "c.Environment LIKE '%" + Environment + "%' AND "; }
                if (Boss != "") { q = q + "c.Boss LIKE '%" + Boss + "%' AND "; }
                if (Cost != "") { q = q + "c.Cost LIKE '%" + Cost + "%' AND "; }
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

        private void ChapterSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zhengruiDataSet3.Chapter' table. You can move, or remove it, as needed.
            this.chapterTableAdapter.Fill(this.zhengruiDataSet3.Chapter);
            conn = new SqlConnection(conn_string);
        }
    }
}
