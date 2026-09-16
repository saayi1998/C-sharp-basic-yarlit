using MySql.Data.MySqlClient;
using System;
using System.Configuration;

public class FamilyDAL
{
    string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString ?? string.Empty;

    public string GetMobileByFamilyId(string familyId)
    {
        string mobile = string.Empty;
        MySqlConnection conn = new MySqlConnection(connString);

        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT mobile_number FROM families WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", familyId);
            object result = cmd.ExecuteScalar();

            mobile = result != null ? result.ToString() : string.Empty;
        }
        finally
        {
            conn.Close();
        }

        return mobile;
    }

    public void DeleteFamily(string familyId)
    {
        MySqlConnection conn = new MySqlConnection(connString);

        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM families WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", familyId);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public string InsertFamily(string mobileNumber)
    {
        string newFamilyId = "";
        MySqlConnection conn = new MySqlConnection(connString);

        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO families(mobile_number) VALUES(@mobile)", conn);
            cmd.Parameters.AddWithValue("@mobile", mobileNumber);
            cmd.ExecuteNonQuery();

            MySqlCommand getIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
            newFamilyId = getIdCmd.ExecuteScalar().ToString();
        }
        finally
        {
            conn.Close();
        }

        return newFamilyId;
    }

    public int UpdateFamilyMobile(string familyId, string mobileNumber)
    {
        int affectedRows = 0;
        MySqlConnection conn = new MySqlConnection(connString);

        try
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE families SET mobile_number = @mobile WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@mobile", mobileNumber);
            cmd.Parameters.AddWithValue("@id", familyId);
            affectedRows = cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }

        return affectedRows;
    }
}