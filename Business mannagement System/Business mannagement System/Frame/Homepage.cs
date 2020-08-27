using Business_mannagement_System.Frame;
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
    public partial class Homepage : MetroFramework.Forms.MetroForm
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      /*  private void metroButton2_Click(object sender, EventArgs e)
        {
            var customercontrol = new Customerpanel();
            customercontrol.Dock = DockStyle.Fill ;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(customercontrol);


        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            var customercontrol = new Customerpanel();
            customercontrol.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(customercontrol);
            label1.Text = "Customer";

        }

        private void Sellbtn_Click(object sender, EventArgs e)
        {
            var sellcontrol = new Sellpanel();
            sellcontrol.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(sellcontrol);
            label1.Text = "Sell";

        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            var product = new Productpanel();
            product.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(product);
            label1.Text = "Product";

        }

        private void Graphbtn_Click(object sender, EventArgs e)
        {
            var graph = new Graphpanel();
            graph.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(graph);
            label1.Text = "Statistics";
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            var emp = new Employeepanel();
            emp.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(emp);
            label1.Text = "Employee";

        }

        private void Supplierbtn_Click(object sender, EventArgs e)
        {
            var sup = new Suplierpanel();
            sup.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(sup);
            label1.Text = "Supplier";

        }

        private void Cetegorybtn_Click(object sender, EventArgs e)
        {
            var cat = new Cetegorypanel();
            cat.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(cat);
            label1.Text = "Cetegory";

        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            var ad = new Adminpanel();
            ad.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(ad);
            label1.Text = "Admin panel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var o = new Ownerpanel();
            o.Dock = DockStyle.Fill;
            metroPanel3.Controls.Clear();
            metroPanel3.Controls.Add(o);
            label1.Text = "Owner Info";
        }
    }
}
