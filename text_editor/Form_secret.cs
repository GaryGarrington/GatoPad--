using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_editor
{
    public partial class Form_secret : Form
    {
        public Form_secret()
        {
            InitializeComponent();
        }

        private void pcb_briefcase_Click(object sender, EventArgs e)
        {
            Form_alert alert = new Form_alert();
            alert.ShowDialog();
            this.Close();
        }
    }
}
