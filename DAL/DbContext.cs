using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace My_college_project.DAL
{
    static internal class DbContext
    {
        static readonly private string connString;
        static DbContext()
        {
            connString = new ConfigurationBuilder()
                      .AddUserSecrets<Program>()
                      .Build()["ConnectionString"];

            if (string.IsNullOrEmpty(connString))
            {
                throw new ArgumentNullException("Connection string is missing");
            }
        }

        static public void InitDB()
        {
            try
            {
                var result = ScalarQuery("SELECT 1+1 AS test", null!);
                if (result == null)
                {
                    throw new Exception("Failed to connect to the database.");
                }
            }
            catch (Exception )
            {
                throw new Exception("something went wrong");
            }
            //בדיקה לא מושלמת, אם אחת הטבלאות לא קיימות מניחים שכולם לא קיימות מייצרים אותם ומזינים נתונים 
            DataTable dt = AdapterQuery("SELECT * FROM sys.tables WHERE name = 'users' AND type = 'U'", null);
            if(dt.Rows.Count == 0)
            {
                NoneQuery(Seed.GetCreateQuery(), null);
                NoneQuery(Seed.GetInsertQuery(), null);
            }
            
        }

        static public DataTable AdapterQuery(string Query, SqlParameter[]? sqlParams)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    if (sqlParams != null)
                    {
                        cmd.Parameters.AddRange(sqlParams);
                    }
                    try
                    {
                        con.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                        return dt;
                    }
                }
            }
            return dt;
        }

        static public object? ScalarQuery(string Query, SqlParameter[] sqlParams)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    if (sqlParams != null)
                    {
                        cmd.Parameters.AddRange(sqlParams);
                    }
                    try
                    {
                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                        return null;
                    }
                }
            }
        }

        static public int NoneQuery(string Query, SqlParameter[]? sqlParams)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    if (sqlParams != null)
                    {
                        cmd.Parameters.AddRange(sqlParams);
                    }
                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                        return -1;
                    }
                }
            }
        }
    }
}
