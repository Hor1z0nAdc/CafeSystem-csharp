using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class Form1 : Form
    {
        private int salt = 13;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            bool isValidUser = true;

            string query = $"select * from users where username='{usernameField.Text}';";
            DataSet dataset = Database.loadData(query);
            Debug.WriteLine(dataset.Tables[0].Rows.Count);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                isValidUser = false;
                errorLabel.Visible = true;
                errorLabel.Text = "User doesn't exists!";
            }
            else
            {
                isValidUser = BCrypt.Net.BCrypt.Verify(passwordField.Text, dataset.Tables[0].Rows[0]["password"].ToString());

                if (isValidUser)
                {
                    int isAdmin = Convert.ToInt32(dataset.Tables[0].Rows[0]["isAdmin"]);

                    if (isAdmin == 1)
                    {
                        Dashboard dashboard = new Dashboard("admin");
                        dashboard.Show();
                    }
                    else
                    {
                        Dashboard dashboard = new Dashboard(dataset.Tables[0].Rows[0]["username"].ToString());
                        dashboard.Show();
                    }
                    this.Hide();

                }
                else
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = "Password is incorrect!";
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            bool isTooBig = tooBig();

            while(isTooBig)
            {
                string newValue = usernameField.Text.Substring(0, usernameField.Text.Length - 1);
                usernameField.Text = newValue;
                usernameField.SelectionStart = usernameField.Text.Length;
                isTooBig = tooBig();
            }
        }

        private bool tooBig()
        {
            Size size = TextRenderer.MeasureText(usernameField.Text, usernameField.Font);
            return (size.Width > usernameField.Width) || (size.Height > usernameField.Height);
        }
    }
}
