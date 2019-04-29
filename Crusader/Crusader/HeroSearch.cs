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
    public partial class HeroSearch : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;

        public HeroSearch()
        {
            InitializeComponent();
        }

        private void HeroSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zhengruiDataSet2.Hero' table. You can move, or remove it, as needed.
            this.heroTableAdapter.Fill(this.zhengruiDataSet2.Hero);
            conn = new SqlConnection(conn_string);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string HeroName = txtHeroName.Text;
                string HP = txtHP.Text;
                string ATK = txtATK.Text;
                string SoulboundWeapon = txtSoulboundWeapon.Text;
                string Contract = txtContract.Text;
                string Faction = txtFaction.Text;
                string Class = txtClass.Text;
                string order = "SELECT * FROM Crusader.Hero h WHERE ";
                q = "";
                if (HeroName != "") { q = q + "h.HeroName LIKE '%" + HeroName + "%' AND "; }
                if (HP != "") { q = q + "h.HP LIKE '%" + HP + "%' AND "; }
                if (ATK != "") { q = q + "h.ATK LIKE '%" + ATK + "%' AND "; }
                if (SoulboundWeapon != "") { q = q + "h.SoulboundWeapon LIKE '%" + SoulboundWeapon + "%' AND "; }
                if (Contract != "") { q = q + "h.[Contract] LIKE '%" + Contract + "%' AND "; }
                if (Faction != "") { q = q + "h.Faction LIKE '%" + Faction + "%' AND "; }
                if (Class != "") { q = q + "h.Class LIKE '%" + Class + "%' AND "; }
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
    }
}
