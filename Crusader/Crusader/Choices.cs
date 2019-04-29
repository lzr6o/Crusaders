using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crusader
{
    public partial class Choices : Form
    {
        public Choices()
        {
            InitializeComponent();
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            new NPCModify().ShowDialog();
        }
    }
}
