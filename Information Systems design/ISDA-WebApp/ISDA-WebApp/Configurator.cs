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

        public DataTable LoadSpecialties()
        {
            DataTable result = new DataTable();
            result.Columns.Add("id");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT SpecialtyId, Name FROM Specialty ORDER BY SpecialtyId ASC";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SpecialtyId"]);
                    string name = Convert.ToString(reader["Name"]);
                    DataRow row = result.NewRow();
                    row[0] = id;
                    row[1] = name;
                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }

        public Specialty LoadSpecialtyById(int id)
        {
            Specialty result = null;
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT * FROM Specialty WHERE SpecialtyId = @SpecialtyId";
            SqlParameter param = null;
            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    result = new Specialty();

                    string name = Convert.ToString(reader["Name"]);
                    result.Id = id;
                    result.Name = name;
                }
            }
            connection.Close();
            return result;
        }

        public void UpdateSpecialty(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE Specialty SET Name = @Name WHERE SpecialtyId = @SpecialtyId";
            SqlParameter param = null;
            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable LoadSubjects()
        {
            DataTable result = new DataTable();
            result.Columns.Add("id");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT SubjectId, Name FROM Subject ORDER BY SubjectId";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SubjectId"]);
                    string name = Convert.ToString(reader["Name"]);
                    DataRow row = result.NewRow();
                    row[0] = id;
                    row[1] = name;
                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }

        public Subject LoadSubjectById(int id)
        {
            Subject result = null;
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT * FROM Subject WHERE SubjectId = @SubjectId";
            SqlParameter param = null;
            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    result = new Subject();

                    string name = Convert.ToString(reader["Name"]);
                    result.Id = id;
                    result.Name = name;
                }
            }
            connection.Close();
            return result;
        }

        public void UpdateSubject(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE Subject SET Name = @Name WHERE SubjectId = @SubjectId";
            SqlParameter param = null;
            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}