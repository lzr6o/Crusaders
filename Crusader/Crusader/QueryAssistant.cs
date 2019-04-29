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
    public partial class QueryAssistant : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String error_msg = "";
        String q = "";
        SqlConnection conn = null;
        public QueryAssistant()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conn_string);
                conn.Open();
                disconnectToolStripMenuItem.Enabled = true;
                connectToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                disconnectToolStripMenuItem.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            run_Query();
            this.Cursor = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectToolStripMenuItem.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnectToolStripMenuItem.PerformClick();
        }

        private void run_Query()
        {
            error_msg = "";
            q = query_box.Text;
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataAdapter a = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                a.SelectCommand = cmd;
                a.Fill(dt);

                results.DataSource = dt;
                results.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                error_msg = ex.Message;
                MessageBox.Show(error_msg);
            }
        }
    }
}
