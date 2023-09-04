using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            Khoa a = new Khoa();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                    item.Close();
            }
            XemDiem f = new XemDiem();
            f.MdiParent = this;
            f.Show();

        }
    }
}
