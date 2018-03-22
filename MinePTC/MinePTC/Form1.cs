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
            this.webKitBrowser1.Navigated +=
            new WebBrowserNavigatedEventHandler(webKitBrowser1_Navigated);
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
            
            webKitBrowser1.Navigate("http://www.minarpesetacoin.com/?refer=263");

        }

        void webKitBrowser1_Navigated(object sender,
                WebBrowserNavigatedEventArgs e)
        {
            txtbdireccion.Text = webKitBrowser1.Url.ToString();
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
