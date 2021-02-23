using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ISDA_Proj
{
    public class Configurator
    {
        private DBManipulator manipulator;

        public Configurator()
        {
            this.manipulator = new DBManipulator();
        }

        public void SaveSpecialty(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = "INSERT INTO Specialty (SpecialtyId, Name) VALUES(@SpecialtyId, @Name)";

                SqlParameter param = null;
                param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
                param.Value = id;
                command.Parameters.Add(param);
                param = new SqlParameter("@Name", SqlDbType.VarChar);
                param.Value = name;
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}