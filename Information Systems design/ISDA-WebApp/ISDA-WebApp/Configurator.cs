using ISDA_WebApp.Models;
using ISDA_WebApp_Models;
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

        public DataTable LoadStudents()
        {
            DataTable result = new DataTable();

            result.Columns.Add("fNumber");
            result.Columns.Add("specialtyName");
            result.Columns.Add("fName");
            result.Columns.Add("mName");
            result.Columns.Add("lName");
            result.Columns.Add("address");
            result.Columns.Add("phone");
            result.Columns.Add("eMail");

            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText = "SELECT * FROM Student " +
                "JOIN Specialty ON Student.SpecialtyId = Specialty.SpecialtyId " +
                "ORDER BY FNumber";

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string fNumber = Convert.ToString(reader["FNumber"]);
                    string specialtyName = Convert.ToString(reader["Name"]);
                    string fName = Convert.ToString(reader["FName"]);
                    string mName = Convert.ToString(reader["MName"]);
                    string lName = Convert.ToString(reader["LName"]);
                    string address = Convert.ToString(reader["Address"]);
                    string phone = Convert.ToString(reader["Phone"]);
                    string eMail = Convert.ToString(reader["EMail"]);

                    DataRow row = result.NewRow();

                    row[0] = fNumber;
                    row[1] = specialtyName;
                    row[2] = fName;
                    row[3] = mName;
                    row[4] = lName;
                    row[5] = address;
                    row[6] = phone;
                    row[7] = eMail;

                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }

        public Student LoadStudentByFNumber(string fNumber)
        {
            Student result = null;
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT * FROM Student WHERE FNumber = @FNumber";
            SqlParameter param = null;

            param = new SqlParameter("@FNumber", SqlDbType.VarChar);
            param.Value = fNumber;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    result = new Student();

                    int specialtyId = Convert.ToInt32(reader["SpecialtyId"]);
                    string fName = Convert.ToString(reader["FName"]);
                    string mName = Convert.ToString(reader["MName"]);
                    string lName = Convert.ToString(reader["LName"]);
                    string address = Convert.ToString(reader["Address"]);
                    string phone = Convert.ToString(reader["Phone"]);
                    string eMail = Convert.ToString(reader["EMail"]);

                    result.FNumber = fNumber;
                    result.SpecialtyId = specialtyId;
                    result.FName = fName;
                    result.MName = mName;
                    result.LName = lName;
                    result.Address = address;
                    result.Phone = phone;
                    result.EMail = eMail;
                }
            }

            connection.Close();
            return result;
        }

        public void UpdateStudent(string fNumber, int specialtyId, string fName,
            string mName, string lName, string address, string phone, string eMail)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();

            command.CommandText =
                "UPDATE Student SET " +
                "SpecialtyId = @SpecialtyId," +
                "FName = @FName, " +
                "MName = @MName, " +
                "LName = @LName, " +
                "Address = @Address, " +
                "Phone = @Phone, " +
                "EMail = @EMail " +
                "WHERE FNumber = @FNumber";

            SqlParameter param = null;

            param = new SqlParameter("@FNumber", SqlDbType.VarChar);
            param.Value = fNumber;
            command.Parameters.Add(param);

            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = specialtyId;
            command.Parameters.Add(param);

            param = new SqlParameter("@FName", SqlDbType.VarChar);
            param.Value = fName;
            command.Parameters.Add(param);

            param = new SqlParameter("@MName", SqlDbType.VarChar);
            param.Value = mName;
            command.Parameters.Add(param);

            param = new SqlParameter("@LName", SqlDbType.VarChar);
            param.Value = lName;
            command.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.VarChar);
            param.Value = address;
            command.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.VarChar);
            param.Value = phone;
            command.Parameters.Add(param);

            param = new SqlParameter("@EMail", SqlDbType.VarChar);
            param.Value = eMail;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}