using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DataAccess2
{
    public class clsSqlServer
    {
        public DataSet getCountries()
        {
           
                string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
                SqlConnection objConnection = new SqlConnection(ConnectionString);
                objConnection.Open();
                SqlCommand objCommand = new SqlCommand("Select * from CountryMaster ", objConnection);
                DataSet objDataset = new DataSet();
                SqlDataAdapter objAdaptar = new SqlDataAdapter(objCommand);
                objAdaptar.Fill(objDataset);

                objConnection.Close();
                return objDataset;
            
        }
        public DataSet getUser(string UserName,string PassWord)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand("Select * from Users where Username='" + UserName +"' and Password='" + PassWord +"' ", objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdaptar = new SqlDataAdapter(objCommand);
            objAdaptar.Fill(objDataset);

            objConnection.Close();
            return objDataset;
        }
        public DataSet getCustomers()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand("SELECT Id,custName,Gender,Hobbies,Status,Address,Email,Countryname from Demo inner join CountryMaster on CountryId_FK = Countryid ", objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdaptar = new SqlDataAdapter(objCommand);
            objAdaptar.Fill(objDataset);

            objConnection.Close();
            return objDataset;
        }
        public DataSet getCustomers(int Customercode)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            string query = "Select * from Demo where Id = " + Customercode + "";
            SqlCommand objCommand = new SqlCommand(query, objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdaptar = new SqlDataAdapter(objCommand);
            objAdaptar.Fill(objDataset);

            objConnection.Close();
            return objDataset;
        }
    
        public bool InsertCustomers(string custName,
                                    int country,
                                    string Gender,
                                    string Hobbies,
                                    string Status,
                                    string Address,
                                    string Email)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            try
            {
                
                String query = "Insert into Demo values('" 
                                                 + custName + "','" 
                                                 + Gender   + "','"
                                                 + Hobbies + "','" 
                                                 + Status + "','" 
                                                 + Address + "','" 
                                                 + Email + "',"+ country  + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Sucssesfully...!");
                }
                else
                {
                    MessageBox.Show("Failed....!");
                }
                
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
   
        public bool UpdateCustomers(string custName,
                                    int country,
                                    string Gender,
                                    string Hobbies,
                                    string Status,
                                    string Address,
                                    int StrId,
                                    string Email)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "Update Demo set custName='" + custName + "',CountryId_FK="
                                                        + country + ",Gender='"
                                                        + Gender + "',Hobbies='"
                                                        + Hobbies + "',Status='"
                                                        + Status + "',Address='"
                                                        + Address + "',Email='"
                                                        + Email+ "' where Id="
                                                        + StrId + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated Sucssesfully...!");
            }
            else
            {
                MessageBox.Show("Failed....!");
            }
            conn.Close();
            return true;
        }
        
        public bool DeleteCustomer(string custName)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(ConnectionString);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand("delete from Demo where custName ='"
                                                    + custName + "'",
                                                    objConnection);
            // objCommand.ExecuteNonQuery();
            int a = objCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted Sucssesfully...!");
            }
            else
            {
                MessageBox.Show("Failed....!");
            }
            objConnection.Close();
            return true;
        }
    }

}
