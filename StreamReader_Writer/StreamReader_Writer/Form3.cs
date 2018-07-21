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

namespace StreamReader_Writer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Stream writer";
            this.label1.Text = "File location";
            this.label2.Text = "File Name";
            this.button1.Text = "Write";
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox2.Text + textBox3.Text);
            sw.Write(this.textBox1.Text);
            MessageBox.Show("file has been written");
            sw.Close();
        }
    }
}
