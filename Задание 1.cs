using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Задание_1
{
    public partial class Lab_7 : Form
    {
        public Lab_7()
        {
            InitializeComponent();
        }

        private void Lab_7_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";
            file2.Filter = "(*.jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string fname;
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);
            textBox1.Text = file1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file2.ShowDialog();
            string filename = file2.FileName;
            pct.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
