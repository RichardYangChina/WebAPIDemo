using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Models;

namespace WebAPIDemo.DAO
{
    public class DBConnect
    {
        private const string connectionString = @"Data Source=DLC5CG745137FLH\SQL2014;Initial Catalog=MyDemo;Integrated Security=True";

        public IList<TUser> GetUserData() {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var resultList = new List<TUser>();
                var queryString = @"select * from T_USER";
                queryString = @"update T_USER set NAME='Richard Yang' where ID = 1";
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var result = new TUser();
                        result.Name = reader[1].ToString();
                        result.Sex = (Boolean)reader[2];
                        result.Username = reader[3].ToString();
                        result.Passcode = reader[4].ToString();
                        result.Mygift = reader[5].ToString();
                        resultList.Add(result);
                    }
                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return resultList;
            }
        }

        public string UpdateUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var result = "";
                var queryString = @"update T_USER set NAME='Richard Yang' where ID = 1";
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);
                try
                {
                    connection.Open();
                    result = command.ExecuteNonQuery().ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return result;
            }
        }
    }
}
