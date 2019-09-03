using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Eleima_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                this.Text = string.Concat("visor de imagenes(" + openFileDialog1.FileName + ")");
            }
        }

        private void Openc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openc.LinkVisited = true;
            System.Diagnostics.Process.Start("Calc");
        }

        private void Ucol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucol.LinkVisited = true;
            System.Diagnostics.Process.Start("IExplore", "http://www.ucol.mx");
        }
    }
}
