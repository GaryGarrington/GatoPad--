using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using text_editor.Properties;
using System.Media;

namespace text_editor
{
    public partial class Form_alert : Form
    {
        SoundPlayer sound = new SoundPlayer(Resources.intruderalert);
        public Form_alert()
        {
            InitializeComponent();
        }

        private void Form_alert_Load(object sender, EventArgs e)
        {
            sound.Play();
        }

        private void Form_alert_FormClosing(object sender, FormClosingEventArgs e)
        {
            sound.Stop();
        }
    }
}
