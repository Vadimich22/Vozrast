using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Возраст_1
{
    public partial class Vlad1 : Form
    {
        public Vlad1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fForm1 = new Form1();
            fForm1.Show();
            fForm1.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
