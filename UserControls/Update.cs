using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.UserControls
{
    public partial class Update : UserControl
    {
        private int selectedItemId;

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double priceValue = Convert.ToDouble(updatedPrice.Text);
            Database.updateItem(selectedItemId, updatedName.Text, updatedCategory.Text, priceValue);

            MessageBox.Show("Item updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            Clear();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
           Clear();
        } 

        private void searchedName_TextChanged(object sender, EventArgs e)
        {
            DataSet dataSet = Database.loadData($"select * from item where name like '{searchedName.Text}%'");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Clear()
        {
            searchedName.Clear();
            updatedCategory.SelectedIndex = -1;
            updatedName.Clear();
            updatedPrice.Clear();
        }

        private void LoadData()
        {
            DataSet dataSet = Database.loadData("select * from item");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            try
            {
                selectedItemId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                String price = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String category = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                updatedName.Text = name;
                updatedPrice.Text = price;
                updatedCategory.Text = category;
            }
            catch {}
        }
    }
}
