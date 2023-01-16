using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadNBun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.FromArgb(78, 47, 38);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Cursor = Cursors.Hand;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = width;
            this.Height = height - 40;
            this.Top = 0;
            this.Left = 0;
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.TopLevel = false;
            panel3.Controls.Add(frmProduct);
            frmProduct.BringToFront();
            frmProduct.Show();
        }
    }
}
