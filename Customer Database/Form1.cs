using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Database
{
    public partial class Form1 : Form
    {

        private DataTable searchDataTable = new DataTable();
        private DataTable queryDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = searchDataTable;
            this.datagridForQuery.DataSource = queryDataTable;
            this.topLabel.Hide();
            this.topText.Hide();
        }

        private static string loadCn()
        {
            var cn = "";
            StreamReader sr = new StreamReader(@"..\..\Resources\resources.txt");
            cn = sr.ReadLine();
            return cn;
        }

        private readonly string connectionString = loadCn();

        private class Customer
        {
            private String firstName { get; set; }
            private String lastName { get; set; }
            private String address { get; set; }
            private String city { get; set; }
            private String state { get; set; }
            private String zip { get; set; }
            private String email { get; set; }
            private String phone { get; set; }

            public Customer(String fn, String ln, String add, String cityIn, String stateIn, String zipIn,
                String emailIn, String phoneIn)
            {
                firstName = fn;
                lastName = ln;
                address = add;
                city = cityIn;
                state = stateIn;
                zip = zipIn;
                email = emailIn;
                phone = phoneIn;
            }
        }

        private void clearAllText()
        {
            firstNameBox.Clear();
            lastNameBox.Clear();
            address1Box.Clear();
            cityBox.Clear();
            stateSelectBox.SelectedValue = 1;
            zipCodeBox.Clear();
            emailTextbox.Clear();
            phoneTextbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set focus to tab with data from database
            this.MainDisplay.SelectedTab = lookupTab;

            searchDataTable.Clear();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                //select all from any row, in any column, that matches the search term
                SqlCommand cmd = new SqlCommand
                    ("SELECT * FROM Customers WHERE firstname LIKE @searchTerm" +
                     " OR lastName LIKE @searchTerm" +
                     " OR address LIKE @searchTerm" +
                     " OR city LIKE @searchTerm" +
                     " OR state LIKE @searchTerm" +
                     " OR zip LIKE @searchTerm" +
                     " OR email LIKE @searchTerm" +
                     " OR phone LIKE @searchTerm", connection);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm.Text + "%");
                cmd.Connection = connection;

                searchDataTable.Load(cmd.ExecuteReader());

                if (searchDataTable.Rows.Count == 0)
                    MessageBox.Show("No Results Found");
            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (
                SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO Customers (firstName,lastName,address,city, state,zip,email,phone) VALUES (@first,@last,@address,@city,@state,@zip,@email,@phone)")
                )
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@first", firstNameBox.Text);
                cmd.Parameters.AddWithValue("@last", lastNameBox.Text);
                cmd.Parameters.AddWithValue("@address", address1Box.Text);
                cmd.Parameters.AddWithValue("@city", cityBox.Text);
                cmd.Parameters.AddWithValue("@state", stateSelectBox.Text);
                cmd.Parameters.AddWithValue("@zip", zipCodeBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextbox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTextbox.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added!");
                connection.Close();
                clearAllText();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            queryDataTable.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    //select all from any row, in any column, that matches the search term
                    SqlCommand cmd = new SqlCommand(sqlQueryTextbox.Text, connection);
                    cmd.Connection = connection;

                    queryDataTable.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query is invalid!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                topLabel.Show();
                topText.Show();
            }
            else
            {
                topLabel.Hide();
                topText.Hide();
            }
        }
    }


}


