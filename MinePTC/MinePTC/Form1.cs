using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinePTC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.minarpesetacoin.com/?refer=263");
            txtbdireccion.Text = "www.minarpesetacoin.com/?refer=263";
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtbdireccion.Text);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }
    }
}
