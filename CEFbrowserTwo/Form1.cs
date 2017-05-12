using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CEFbrowserTwo
{
    public partial class Form1 : Form
    {
        
        private ChromiumWebBrowser Web;
        public Form1()
        {
            InitializeComponent();
           
        }
        public void InitializeChromium()
        {

        }

        private void browserWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //解决高分辨率
            Cef.EnableHighDPISupport();
            Cef.Initialize(new CefSettings());
            Web = new ChromiumWebBrowser("http://localhost:3000");
            this.Controls.Add(Web);
            Web.Dock = DockStyle.Fill;
           
        }
    }
}
