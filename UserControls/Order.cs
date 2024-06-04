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
    public partial class Order : UserControl
    {
        private List<ListItem> items = new List<ListItem>();
        private List<OrderedItem> orderedItems = new List<OrderedItem>();
        private double sum = 0;
        public int WorkerID { get; set; }
        public string WorkerName { get; set; }

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            categoryBox.SelectedIndex = 0;
            orderButton.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataSet = Database.loadData($"Select * from item where category='{categoryBox.Text}'");
            updateItemList(dataSet);
            searchedName.Clear();
        }

        private void searchedName_TextChanged(object sender, EventArgs e)
        {

            DataSet dataSet = Database.loadData($"Select * from item where category='{categoryBox.Text}' and name like '{searchedName.Text}%'");
            updateItemList(dataSet);
        }

        private void updateItemList(DataSet dataSet)
        {
            itemList.Items.Clear();
            items.Clear();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                int id = (int)dataSet.Tables[0].Rows[i][1];
                string name = dataSet.Tables[0].Rows[i][0].ToString();
                double price = Convert.ToDouble(dataSet.Tables[0].Rows[i][2]);
                string category = dataSet.Tables[0].Rows[i][3].ToString();

                items.Add(new ListItem(id, name, price, category));
                itemList.Items.Add(name);
            }
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = itemList.SelectedIndex;
            if(index < 0)
            {
                return;
            }

            ListItem item = items[index];

            quantity.Value = 1;
            itemName.Text = item.name;
            itemPrice.Text = item.price.ToString();
            totalItemPrice.Text = itemPrice.Text;
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {   
            int index = itemList.SelectedIndex;
            if(index == -1)
            {
                return;
            }

            int itemQuantity = Convert.ToInt32(quantity.Value);
            ListItem item = items[index];

            totalItemPrice.Text = (item.price * itemQuantity).ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            orderButton.Enabled = true;
            ListItem item = items.Find(i => i.name == itemName.Text);

            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = itemName.Text;
            dataGridView1.Rows[index].Cells[1].Value = itemPrice.Text;
            dataGridView1.Rows[index].Cells[2].Value = quantity.Value;
            dataGridView1.Rows[index].Cells[3].Value = totalItemPrice.Text;
            dataGridView1.Rows[index].Cells[4].Value = item.id;

            string price = totalItemPrice.Text.Replace(",", ".");
            sum += double.Parse(price, System.Globalization.CultureInfo.InvariantCulture);
            setTotalSum();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void setTotalSum()
        {
            totalSum.Text = sum.ToString() + " €";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string price = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].ToString();
                string processedPrice = totalItemPrice.Text.Replace(",", ".");
                double amount = double.Parse(processedPrice, System.Globalization.CultureInfo.InvariantCulture);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                sum -= amount;
                setTotalSum();

                Debug.WriteLine(dataGridView1.Rows.Count);
                if(dataGridView1.Rows.Count == 1)
                {
                    orderButton.Enabled = false;
                }
            } catch {}
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            orderedItems.Clear();
            for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                double priceSum = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                int id = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                orderedItems.Add(new OrderedItem(id, name, quantity, priceSum));
            }

            Database.placeOrder(sum, WorkerID, orderedItems);

            var messageResult = MessageBox.Show("Do you want to print the order", "Successful order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(messageResult == DialogResult.Yes)
            {
                PdfCreator.createPdf(orderedItems, WorkerName, sum.ToString());
            }

            Clear();
            itemList.SelectedIndex = -1;
            itemName.Text = "";
            itemPrice.Text = "";
            totalItemPrice.Text = "";
        }

        public void Clear()
        {
            orderButton.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            sum = 0;
            setTotalSum();
        }

        private void Order_VisibleChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(Visible);
            if (Visible && !Disposing)
            {
                DataSet dataSet = Database.loadData($"Select * from item where category='{categoryBox.Text}'");
                updateItemList(dataSet);
            }
        }
    }
}
