using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phanso
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsPhanso a, b, c;
            a = new ClsPhanso(int.Parse(ts1.Text), int.Parse(ms1.Text));
            b = new ClsPhanso(int.Parse(ts2.Text), int.Parse(ms2.Text));
            if(rbCong.Checked == true)
            {
                c = ClsPhanso.Cong(a, b);
            }
            else if (rbtru.Checked == true)
            {
                c = ClsPhanso.Tru(a, b);
            }
            else if (rbnhan.Checked == true)
            {
                c = ClsPhanso.Nhan(a, b);
            }
            else if(rbchia.Checked == true)
            {
                c = ClsPhanso.Chia(a, b);
            }
            else
            {
                c = new ClsPhanso();
            }
            ts3.Text = c.tuso.ToString();
            ms3.Text = c.mauso.ToString();
        }
    }
}
