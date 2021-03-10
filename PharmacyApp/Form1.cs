using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcWelcome.Location = new Point((pcWelcome.Parent.ClientSize.Width - pcWelcome.ClientSize.Width) / 2,
               pcWelcome.Parent.ClientSize.Height - pcWelcome.ClientSize.Height -130
               ); 
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Medicine add_Medicine = new Add_Medicine();
            add_Medicine.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
