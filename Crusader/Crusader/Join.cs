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
    public partial class Join : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;

        public Join()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string NPCName = txtNPCName.Text;
                string HeroName = txtHeroName.Text;
                string Faction = txtFaction.Text;
                string order = "SELECT n.NPCName, h.HeroName, h.Faction FROM Crusader.Hero h INNER JOIN Crusader.NPC n ON n.Faction = h.Faction WHERE ";
                q = "";
                if (NPCName != "") { q = q + "n.NPCName LIKE '%" + NPCName + "%' AND "; }
                if (HeroName != "") { q = q + "h.HeroName LIKE '%" + HeroName + "%' AND "; }
                if (Faction != "") { q = q + "h.Faction LIKE '%" + Faction + "%' AND "; }
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

        private void Join_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conn_string);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string s = "The results will show a Faction the Heroes and NPC both belong to";
            MessageBox.Show(s, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
