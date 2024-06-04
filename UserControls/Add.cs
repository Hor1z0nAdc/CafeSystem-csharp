using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.UserControls
{
    public partial class Add : UserControl
    {

        public Add()
        {
            InitializeComponent();
            category.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double priceValue = Convert.ToDouble(price.Text);
            Database.addItem(name.Text, category.Text, priceValue);

            MessageBox.Show("Item added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void Add_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            category.SelectedIndex = 0;
            price.Clear();
            name.Clear();

        }
    }
}
