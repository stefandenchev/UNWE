using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ISDA_Proj
{
    public class DBManipulator
    {
        private readonly static string connectionString =
            "Server=.;Database=ISDA;Integrated Security=True;";

        private SqlConnection connection;
        private SqlCommand command;

        public DBManipulator()
        {
            try
            {
                this.connection = new SqlConnection(connectionString);
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public SqlConnection GetConnection()
        {
            return this.connection;
        }
        public SqlCommand GetCommand()
        {
            this.command.Parameters.Clear();
            return this.command;
        }
    }
}
