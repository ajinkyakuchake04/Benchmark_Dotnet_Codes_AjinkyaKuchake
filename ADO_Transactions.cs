using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Using
using System.Data;//Included Externally


namespace ADO_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=.;Database=OrganizationDB;trusted_connection=true";
            conn.Open();

            SqlTransaction tran = null;

            //Works for both Committing Transactions adn Rolling Back Transactions

            try
            {
                tran = conn.BeginTransaction();
                //First Insertion
                SqlCommand cmd = new SqlCommand("InsertEmployee",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.Parameters.AddWithValue("empno",400);
                cmd.Parameters.AddWithValue("ename","ABC");
                cmd.Parameters.AddWithValue("designation","Software Enggr");
                cmd.Parameters.AddWithValue("salary",500000);

                cmd.ExecuteNonQuery();

                //Second Insertion
                SqlCommand cmd1 = new SqlCommand("InsertEmployee", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Transaction = tran;
                cmd1.Parameters.AddWithValue("empno", 500);
                cmd1.Parameters.AddWithValue("ename", "XYZ");
                cmd1.Parameters.AddWithValue("designation", "Software Developer");
                cmd1.Parameters.AddWithValue("salary", 200000);

                cmd1.ExecuteNonQuery();

                tran.Commit();
                Console.WriteLine("Transaction completed successfully");
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                Console.WriteLine("Error Message:"+ex.Message);
                Console.WriteLine("Transacrtion Rollbacked");
                //throw;
            }
            finally
            {
                conn.Close();
            }

            Console.ReadKey();
        }
    }
}
