using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Database
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "workstation id=cbtestdb.mssql.somee.com;packet size=4096;user id=cboseak_SQLLogin_1;pwd=nfgv76epfv;data source=cbtestdb.mssql.somee.com;persist security info=False;initial catalog=cbtestdb";
        List<Customer> tempCustList = new List<Customer>();

        class Customer
        {
            String firstName { get; set; }
            String lastName { get; set; }
            String address { get; set; }
            String city { get; set; }
            String state { get; set; }
            String zip { get; set; }
            String email { get; set; }
            String phone { get; set; }

            public Customer(String fn, String ln, String add, String cityIn, String stateIn, String zipIn, String emailIn, String phoneIn)
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

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Customers (firstName,lastName,address,city, state,zip,email,phone) VALUES (@first,@last,@address,@city,@state,@zip,@email,@phone)"))
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


        private void button2_Click(object sender, EventArgs e)
        {
            //set focus to tab with data from database
            this.MainDisplay.SelectedTab = lookupTab;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //select all from any row, in any column, that matches the search term
            SqlCommand cmd = new SqlCommand
                ("SELECT * FROM Customers WHERE firstname = @searchTerm" +
                " OR lastName = @searchTerm" +
                " OR address = @searchTerm" +
                " OR city = @searchTerm" +
                " OR state = @searchTerm" +
                " OR zip = @searchTerm" +
                " OR email = @searchTerm" + 
                " OR phone = @searchTerm", connection);
            cmd.Parameters.AddWithValue("@searchTerm", searchTerm.Text);
            cmd.Connection = connection;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //add read items to list of customers
                    Customer input = new Customer(Convert.ToString(reader.GetValue(0)), 
                        Convert.ToString(reader.GetValue(1)), 
                        Convert.ToString(reader.GetValue(7)), 
                        Convert.ToString(reader.GetValue(2)), 
                        Convert.ToString(reader.GetValue(3)), 
                        Convert.ToString(reader.GetValue(4)), 
                        Convert.ToString(reader.GetValue(5)), 
                        Convert.ToString(reader.GetValue(6)));
                    tempCustList.Add(input);
                    
                }
            }

                    

                
            
        }      

    }

}
