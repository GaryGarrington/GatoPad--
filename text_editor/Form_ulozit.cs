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
    public partial class Form_ulozit : Form
    {
        public Form_ulozit()
        {
            InitializeComponent();
        }
        public string result;

        private void form_nacten(object sender, EventArgs e)
        {
            result = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            result = "save";
            this.Close();
        }

        private void btn_notsave_Click(object sender, EventArgs e)
        {
            result = "notsave";
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            result = "cancel";
            this.Close();
        }

        private void form_zavren(object sender, FormClosingEventArgs e)
        {
            if (result == "") result = "cancel";
        }
    }
}
