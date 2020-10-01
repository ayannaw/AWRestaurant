using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;

namespace AWRestaurant.Utilities
{
    public class Customers
    {
        DBConnection connection = new DBConnection();
        SqlCommand customerComm;

        private string name;
        private string email;
        private string phoneNumber;
        private string password;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string updateOn;
        
        public Customers() {        }

        public Customers(string name, string email, string phoneNumber, string password, string address, string city, string state, string zipCode)
        {
            createCustomer(name, email, phoneNumber, password, address, city, state, zipCode);
        }

        /*
         *Creates a customer 
         *adds the customer to the database
         */
        private int createCustomer(string name, string email, string phoneNumber, string password, string address, string city, string state, string zipCode)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.password = password;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.updateOn = DateTime.Now.ToString();

            customerComm = new SqlCommand();
            customerComm.Connection = connection.getConnection();
            customerComm.CommandType = CommandType.StoredProcedure;
            customerComm.CommandText = "AddCustomer";

            customerComm.Parameters.AddWithValue("@name", name);
            customerComm.Parameters.AddWithValue("@email", email);
            customerComm.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            customerComm.Parameters.AddWithValue("@password", password);
            customerComm.Parameters.AddWithValue("@address", address);
            customerComm.Parameters.AddWithValue("@city", city);
            customerComm.Parameters.AddWithValue("@state", state);
            customerComm.Parameters.AddWithValue("@zipCode", zipCode);

            try
            {
                customerComm.Connection.Open();
                int ret = customerComm.ExecuteNonQuery();
                customerComm.Connection.Close();
                return ret;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }


    }
}