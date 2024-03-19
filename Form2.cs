using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using work_1_var_9;
namespace work_1_var_9
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
