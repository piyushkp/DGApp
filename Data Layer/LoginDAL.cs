using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DGApp.Objects;
using System.Data.SqlClient;
using System.Data;

namespace DGApp.Data_Layer
{
    public class LoginDAL
    {
        private Customer _customerInfo;
        public string connectionString;

        public Customer CheckCredentials(string username, string password)
        {
            _customerInfo = new Customer();
            try
            {
                connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Customer WHERE UserName='"+ username+ "' and password='" + password+"'";
                    connection.Open();
                    // Execute the query
                    SqlDataReader  rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        _customerInfo.CustomerID = (int)rdr["CustomerID"];
                        _customerInfo.AnimalID = (int)rdr["AnimalID"];
                        _customerInfo.City = rdr["City"].ToString();
                        _customerInfo.Address = rdr["Address"].ToString();
                        _customerInfo.Email = rdr["Email"].ToString();
                        _customerInfo.FirstName = rdr["FirstName"].ToString();
                        _customerInfo.LastName = rdr["LastName"].ToString();
                        _customerInfo.Password = rdr["Password"].ToString();
                        _customerInfo.Phone = rdr["Phone"].ToString();
                        _customerInfo.UserName = rdr["UserName"].ToString();
                        _customerInfo.ZipCode = rdr["ZipCode"].ToString();                        
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _customerInfo;
        }

        public bool SaveData( Customer _customer, Animal _animal)
        {
            try
            {
                connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Animal (Name, Category, Breed, DateBorn, Gender) VALUES (@Name, @Category, @Breed, @DateBorn, @Gender)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@Name", _animal.Name);
                    cmd.Parameters.AddWithValue("@Category", _animal.Category);
                    cmd.Parameters.AddWithValue("@Breed", _animal.Breed);
                    cmd.Parameters.AddWithValue("@DateBorn", _animal.DateBorn);
                    cmd.Parameters.AddWithValue("@Gender", _animal.Gender);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("SELECT top 1 AnimalID from Animal order by AnimalID desc");
                    cmd1.Connection = connection;
                    // Execute the query
                    SqlDataReader rdr = cmd1.ExecuteReader();
                    while (rdr.Read())
                    {
                        _customer.AnimalID = (int)rdr["AnimalID"];
                    }
                    rdr.Close();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Customer (AnimalID, Email, UserName, Password, Phone, FirstName, LastName) VALUES (@AnimalID, @Email, @UserName, @Password, @Phone, @FirstName, @LastName)");
                    cmd2.Connection = connection;
                    cmd2.Parameters.AddWithValue("@AnimalID", _customer.AnimalID);
                    cmd2.Parameters.AddWithValue("@Email", _customer.Email);
                    cmd2.Parameters.AddWithValue("@UserName", _customer.UserName);
                    cmd2.Parameters.AddWithValue("@Password", _customer.Password);
                    cmd2.Parameters.AddWithValue("@Phone", _customer.Phone);
                    cmd2.Parameters.AddWithValue("@FirstName", _customer.FirstName);
                    cmd2.Parameters.AddWithValue("@LastName", _customer.LastName);

                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
        
    }
}