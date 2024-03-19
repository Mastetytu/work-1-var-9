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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string name, password;
                name = form.textBox1.Text;
                password = form.textBox2.Text;
                User users = new User(name.ToString(), password.ToString());
                SingleTon.DB.Users.Add(users);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

    
        }


       
    }

}
