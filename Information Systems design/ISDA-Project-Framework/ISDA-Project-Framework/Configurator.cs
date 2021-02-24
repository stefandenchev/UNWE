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
                command.CommandText = @"INSERT INTO Specialty (SpecialtyId, Name)
                                        VALUES (@SpecialtyId, @Name)";

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

        public void SaveSubject(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = @"INSERT INTO Subject (SubjectId, Name)
                                        VALUES (@SubjectId, @Name)";

                SqlParameter param = null;

                param = new SqlParameter("@SubjectId", SqlDbType.Int);
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

        public void SaveStudent(int fNumber, int specialtyId, string fName, string mName,
            string lName, string address, string phone, string eMail)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = @"INSERT INTO Student (FNumber, SpecialtyId,
                FName, MName, LName, Address, Phone, EMail) VALUES(@FNumber, @SpecialtyId,
                @FName, @MName, @LName, @Address, @Phone, @EMail)";
                SqlParameter param = null;
                param = new SqlParameter("@FNumber", SqlDbType.Int);
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

        public DataTable LoadSpecialties()
        {
            DataTable result = new DataTable();
            result.Columns.Add("id");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = @"SELECT SpecialtyId, Name FROM Specialty ORDER BY Name ASC";
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public void SaveGrade(int fNumber, int subjectId, int finalGrade)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = "INSERT INTO StudentSubject (FNumber, SubjectId, FinalGrade) VALUES(@FNumber, @SubjectId, @FinalGrade)";
            SqlParameter param = null;
                param = new SqlParameter("@FNumber", SqlDbType.Int);
                param.Value = fNumber;
                command.Parameters.Add(param);
                param = new SqlParameter("@SubjectId", SqlDbType.Int);
                param.Value = subjectId;
                command.Parameters.Add(param);
                param = new SqlParameter("@FinalGrade", SqlDbType.Int);
                param.Value = finalGrade;
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
        public DataTable LoadStudents()
        {
            DataTable result = new DataTable();
            result.Columns.Add("fnumber");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = "SELECT FNumber, FName, LName FROM Student ORDER BY FNumber ASC";
            SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int fNumber = Convert.ToInt32(reader["FNumber"]);
                        string fName = Convert.ToString(reader["FName"]);
                        string lName = Convert.ToString(reader["LName"]);
                        DataRow row = result.NewRow();
                        row[0] = fNumber;
                        row[1] = fNumber + " " + fName + " " + lName;
                        result.Rows.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public DataTable LoadSubjects()
        {
            DataTable result = new DataTable();
            result.Columns.Add("id");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = "SELECT SubjectId, Name FROM Subject ORDER BY Name ASC";
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }



    }
}