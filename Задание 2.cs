using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Задание_2
{
    public partial class Lab7_2 : Form
    {
        public Lab7_2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt2.Text);
            txt2.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txt1.Text;    
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("D:\\ПР7_2.txt"))
            {
                for (int i = 0; i < lst.Items.Count; i++)
                    sw.WriteLine(lst.Items[i].ToString());
            }
            txt1.Text = "D:\\ПР7_2.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        { 
            lstFromfile.Items.Clear();
            using (System.IO.StreamReader sr = new System.IO.StreamReader("D:\\ПР7_2.txt"))
            {
                while (!sr.EndOfStream)
                {
                    lstFromfile.Items.Add(sr.ReadLine());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
