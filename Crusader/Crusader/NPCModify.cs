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
    public partial class NPCModify : Form
    {
        String conn_string = "Data Source=mssql.cs.ksu.edu;Initial Catalog=zhengrui;Integrated Security=True";
        String q = "";
        SqlConnection conn = null;
        int ID = 0;

        public NPCModify()
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string NPCName = txtNPCName.Text;
                string skill = txtSkill.Text;
                string type = txtType.Text;
                string faction = txtFaction.Text;
                q = "INSERT Crusader.NPC (NPCName, Skill, [Type], Faction) VALUES (@NPCName, @Skill, @Type, @Faction)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@NPCName", NPCName);
                cmd.Parameters.AddWithValue("@Skill", skill);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Faction", faction);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Insert");
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtNPCName.Text = "";
            txtFaction.Text = "";
            txtSkill.Text = "";
            txtType.Text = "";
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNPCName.Text != "" && txtSkill.Text != "" && txtFaction.Text != "" && txtType.Text != "")
                {
                    conn.Open();
                    string NPCName = txtNPCName.Text;
                    string skill = txtSkill.Text;
                    string type = txtType.Text;
                    string faction = txtFaction.Text;
                    q = "UPDATE Crusader.NPC set NPCName=@NPCName, Skill=@Skill, [Type]=@Type, Faction=@Faction WHERE NPCId=@id";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.Parameters.AddWithValue("@NPCName", NPCName);
                    cmd.Parameters.AddWithValue("@Skill", skill);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Faction", faction);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Edit");
                    DisplayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string NPCName = txtNPCName.Text;
                q = "DELETE FROM Crusader.NPC WHERE NPCName = '" + NPCName + "'";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Delete");
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtNPCName.Text = "";
            txtFaction.Text = "";
            txtSkill.Text = "";
            txtType.Text = "";
            conn.Close();
        }

        private void NPCModify_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conn_string);
            conn.Open();
            DisplayData();
            conn.Close();
        }

        private void DisplayData()
        {
            q = "SELECT * FROM Crusader.NPC;";
            SqlDataAdapter a = new SqlDataAdapter(q, conn);
            DataTable dt = new DataTable();
            a.Fill(dt);
            results.DataSource = dt;
            results.AutoResizeColumns();
        }

        private void results_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(results.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNPCName.Text = results.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSkill.Text = results.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtType.Text = results.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFaction.Text = results.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
