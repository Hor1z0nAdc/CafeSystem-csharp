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
    public partial class Remove : UserControl
    {
        private int selectedItemId;

        public Remove()
        {
            InitializeComponent();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Database.removeItem(selectedItemId);

            MessageBox.Show("Item removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            searchedName.Clear();
        }

        private void searchedName_TextChanged(object sender, EventArgs e)
        {
            DataSet dataSet = Database.loadData($"select * from item where name like '{searchedName.Text}%'");
            dataGridView1.DataSource = dataSet.Tables[0];
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
            }
            catch { }
        }

        private void Remove_Leave(object sender, EventArgs e)
        {
            searchedName.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
