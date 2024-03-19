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
        AppContext Apx;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = text_USER.Text;
            user.Password = text_Password.Text;
            if (!string.IsNullOrWhiteSpace(text_USER.Text)) Apx.Add(user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Apx.listChanged += SetListBox;
            SetListBox();

    
        }
    public void SetListBox() 
        {
            AppContext.DataSource = null;
            //AppContext.DataSource = Apx.user;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }

}
