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
            this.Load += new EventHandler(Form1_Load);



        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                webKitBrowser1.DocumentText =
                    "<h1><a href=\"http://www.minarpesetacoin.com\">Hello, World!</a></h1>";
            }




        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate(txtbdireccion.Text);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            webKitBrowser1.GoBack();
        }
    }
}
