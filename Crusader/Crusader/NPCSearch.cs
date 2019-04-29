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
    public partial class NPCSearch : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;

        public NPCSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string NPCName = txtNPCName.Text;
                string skill = txtSkill.Text;
                string type = txtType.Text;
                string faction = txtFaction.Text;
                string order = "SELECT * FROM Crusader.NPC n WHERE ";
                q = "";
                if (NPCName != "") { q = q + "n.NPCName LIKE '%" + NPCName + "%' AND "; }
                if (skill != "") { q = q + "n.Skill LIKE '%" + skill + "%' AND "; }
                if (type != "") { q = q + "n.[Type] LIKE '%" + type + "%' AND "; }
                if (faction != "") { q = q + "n.Faction LIKE '%" + faction + "%' AND "; }
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

        private void NPCSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zhengruiDataSet1.NPC' table. You can move, or remove it, as needed.
            this.nPCTableAdapter.Fill(this.zhengruiDataSet1.NPC);
            conn = new SqlConnection(conn_string);
        }


    }
}
