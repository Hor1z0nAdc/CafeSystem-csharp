using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class Dashboard : Form
    {
        private String workerName;

        public Dashboard(String workerName)
        {
            InitializeComponent();
            this.workerName = workerName;

            if (this.workerName == "admin")
            {
                addItemButton.Show();
                UpdateItemButton.Show();
                RemoveItemButton.Show();
            }
            else
            {
                addItemButton.Hide();
                UpdateItemButton.Hide();
                RemoveItemButton.Hide();
            }

            DataSet set = Database.loadData($"select id from users where username='{this.workerName}';");
            order1.WorkerID = Convert.ToInt32(set.Tables[0].Rows[0]["id"]);
            order1.WorkerName = this.workerName;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            order1.Visible = true;
            order1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            this.Hide();
            loginForm.Show();
        }

        private void order1_Load(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            order1.Visible = true;
            order1.BringToFront();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            add1.Visible = true;
            add1.BringToFront();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            update1.Visible = true;
            update1.BringToFront();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            remove1.Visible = true;
            remove1.BringToFront();
        }

        private void remove1_Load(object sender, EventArgs e)
        {

        }

        private void update1_Load(object sender, EventArgs e)
        {

        }
    }
}
