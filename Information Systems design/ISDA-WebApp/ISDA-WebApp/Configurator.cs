using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ISDA_WebApp
{
    public class Configurator
    {
        private DBManipulator manipulator;
        public Configurator()
        {
            this.manipulator = new DBManipulator();
        }
        public bool CheckLogin(string username, string password)
        {
            bool result = false;
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = "SELECT id FROM Login WHERE username = @username AND password = @password";
                SqlParameter param = null;
                param = new SqlParameter("@username", SqlDbType.VarChar);
                param.Value = username;
                command.Parameters.Add(param);
                param = new SqlParameter("@password", SqlDbType.VarChar);
                param.Value = password;
                command.Parameters.Add(param);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        result = true;
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}