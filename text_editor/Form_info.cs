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
    public partial class Form_info : Form
    {
        public Form_info()
        {
            InitializeComponent();
        }

        private void btn_secret_Click(object sender, EventArgs e)
        {
            Form_secret secret = new Form_secret();
            secret.ShowDialog();
        }
    }
}
