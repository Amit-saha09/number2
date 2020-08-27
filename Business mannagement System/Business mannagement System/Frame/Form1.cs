using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_mannagement_System

{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 10)
                label1.Text = "Loading.......";
            if (a == 20)
                label1.Text = "Loading......";
            if (a == 30)
                label1.Text = "Loading.....";
            if (a == 40)
                label1.Text = "Loading....";
            if (a == 50)
                label1.Text = "Loading....";
            if (a == 60)
                label1.Text = "Loading.....";
            if (a == 70)
                label1.Text = "Loading......";
            if (a == 80)
                label1.Text = "Loading.......";
            if (a == 85)
                label1.Text = "Loading........";
            if (a == 90)
                label1.Text = "Loading........";
            if (a == 95)
                label1.Text = "Complete";
            a++;
            if (a >= 100)
            {
                timer1.Enabled = false;
                 this.Hide();
                LoginForm log = new LoginForm();
                log.Show();
               // Application.Exit();
            }
            materialProgressBar1.Value= a;

        }
    }
}
