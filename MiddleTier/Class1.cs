using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess2;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace MiddleTier
{
    public class Class1
    {
        public class customer
        {
            private string _CustomerName = "";
            private int _CountryId = 0;
            private string _Gender = "";
            private string _Hobbies = "";
            private string _Status = "";
            private string _Address = "";
            private int _StrId = 0;
            private string _Email = "";
            public string CustomerName
            {
                get { return _CustomerName; }
                set 
                { 
                    if(value.Length==0)
                    {
                        throw new Exception("Customer name is required");
                    }
                    if(value.Length>20)
                    {
                        throw new Exception("value cannot be greater than 20 characters");
                    }
                    _CustomerName = value;
                }
               
            }
           
            public string Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }
            public string Hobbies 
            {
                get { return _Hobbies; }
                set { _Hobbies = value; }
            }
            public string Status
            {
                get { return _Status; }
                set { _Status = value; }

            }
            public string Address 
            {
                get { return _Address; }
                set { _Address = value; }

            }
            public string Email
            {
                get { return _Email; }
                set
                { 
                    if(value.Length==0)
                    {
                        throw new Exception("Email is required");

                    }
                    Regex o = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-z]{2,3}$");
                    if(!o.IsMatch(value))
                    {
                        throw new Exception("Email address is not in a proper format");
                    }
                    _Email = value;
                }

            }

            public int StrId { get => _StrId; set => _StrId = value; }
            public int CountryId 
            {
                get { return _CountryId; }
                set { _CountryId = value; } 
            }

            public void Save()
            {
                clsSqlServer obj = new clsSqlServer();
                obj.InsertCustomers(_CustomerName,
                                    _CountryId,
                                    _Gender,
                                    _Hobbies,
                                    _Status,
                                    _Address,
                                    _Email);

            }
            public  void Delete()
            {
                clsSqlServer obj = new clsSqlServer();
                obj.DeleteCustomer(_CustomerName);
            }
            public void Update()
            {
                
                clsSqlServer obj = new clsSqlServer();
                obj.UpdateCustomers(_CustomerName,
                                    _CountryId,
                                    _Gender,
                                    _Hobbies,
                                    _Status,
                                    _Address,
                                    _StrId,
                                    _Email);
            }
            public DataSet LoadCustomer()
            {
                clsSqlServer obj = new clsSqlServer();
                return obj.getCustomers();
            }
            public DataSet LoadCustomer(int CustomerName)
            {
                clsSqlServer obj = new clsSqlServer();
                return obj.getCustomers(CustomerName);
            }
        }
    }
}
