using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Included SQLClient for Sql Server
using System.Data;//Included

namespace ADO_Employee_Example1
{
    class EmployeeDAL
    {
        public int InsertEmployee(int empno,string ename,string designation,int salary)
        {
            SqlConnection con = null;  
            SqlCommand cmd = null;
            int res = 0; //since ExecuteNonQuery returns number of affected rows

            try
            {
                //Creating Connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.; Database=OrganizationDB; trusted_connection=true";

                //Opening Connection
                con.Open();

                //Creation of Command
                cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Setting values for different parameteres
                SqlParameter param1 = new SqlParameter("empno", empno);
                SqlParameter param2 = new SqlParameter("ename", ename);
                SqlParameter param3 = new SqlParameter("designation", designation);
                SqlParameter param4 = new SqlParameter("salary", salary);

                //adding the set parameters
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);

                res = cmd.ExecuteNonQuery();

            }
           

            catch (SqlException ex)
            {
                Console.WriteLine("Error Message:" + ex.Message);
                //throw;
            }
            finally
            {
                con.Close();
            }
            return res;
        }


        public int DeleteEmployee(int empno)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int res = 0; //since ExecuteNonQuery returns number of affected rows

            try
            {
                //Creating Connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.; Database=OrganizationDB; trusted_connection=true";

                //Opening Connection
                con.Open();

                //Creation of Command
                cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Setting values for different parameteres 
                SqlParameter param1 = new SqlParameter("empno", empno);

                //adding the set parameters
                cmd.Parameters.Add(param1);

                //stores number of affected rows
                res = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Message:" + ex.Message);
                //throw;
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        public int UpdateEmployee(int empno, string ename, string designation, int salary)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int res = 0; //since ExecuteNonQuery returns number of affected rows

            try
            {
                //Creating Connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.; Database=OrganizationDB; trusted_connection=true";

                //Opening Connection
                con.Open();

                //Creation of Command
                cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Setting values for different parameteres
                SqlParameter param1 = new SqlParameter("empno", empno);
                SqlParameter param2 = new SqlParameter("ename", ename);
                SqlParameter param3 = new SqlParameter("designation", designation);
                SqlParameter param4 = new SqlParameter("salary", salary);

                //adding the set parameters
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);

                res = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Message:" + ex.Message);
                //throw;
            }
            finally
            {
                con.Close();
            }
            return res;
        }


        public SqlDataReader GetEmployeeDetails()
        {
            SqlConnection con = null;
            SqlDataReader reader = null;
            SqlCommand cmd = null;

            try
            {
                //Creating Connection
                con = new SqlConnection();
                con.ConnectionString = "Server=.; Database=OrganizationDB; trusted_connection=true";

                //Opening Connection
                con.Open();

                //Creation of Command
                cmd = new SqlCommand("GetEmployeeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Execution of command andgetting data in the reader
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Message:" + ex.Message);
                //throw;
            }
            return reader;
        }

        public void PrintReader(SqlDataReader reader)
        {
            //Printing Data
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + "\t\t" + reader["ename"].ToString() + "\t\t" + reader[2].ToString() + "\t\t" + reader[3].ToString());
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeDAL dal = new EmployeeDAL();
            int choice;
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("************Menu************");
                Console.WriteLine("1.Insert Record into the Table");
                Console.WriteLine("2.Delete a Record from the Table");
                Console.WriteLine("3.Update a Record from the Table");
                Console.WriteLine("4.Display the details of Employees");
                Console.WriteLine("5.Exit");
                Console.WriteLine();
                Console.Write("Enter your choice:");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Case 1 selected.");
                            Console.WriteLine("Enter Employee Number:");
                            int empno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name:");
                            string ename = Console.ReadLine();
                            Console.WriteLine("Enter Employee Designation:");
                            string designation = Console.ReadLine();
                            Console.WriteLine("Enter Employee Salary:");
                            int salary = Convert.ToInt32(Console.ReadLine());

                            dal.InsertEmployee(empno, ename, designation, salary);
                            Console.WriteLine("Data Inserted Successfully");
                            break;

                    case 2: Console.WriteLine("Case 2 selected.");
                            Console.Write("Enter the Empolyee Number you wish to delete the record of:");
                            int empno1 = Convert.ToInt32(Console.ReadLine());
                            dal.DeleteEmployee(empno1);
                            Console.WriteLine("Record Deleted Successfully");
                            break;

                    case 3: Console.WriteLine("Case 3 selected.");
                            Console.Write("Enter the Employee Number whose record you wish to update:");
                            int empno2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Employee Name:");
                            string ename2 = Console.ReadLine();
                            Console.Write("Enter Employee Designation:");
                            string designation2 = Console.ReadLine();
                            Console.Write("Enter Employee Salary:");
                            int salary2 = Convert.ToInt32(Console.ReadLine());

                            dal.UpdateEmployee(empno2, ename2, designation2, salary2);
                            Console.WriteLine("Data Updated Successfully");
                            break;

                    case 4: Console.WriteLine("Case 4 Selected.");
                            dal.PrintReader(dal.GetEmployeeDetails());
                            break;

                    case 5: System.Environment.Exit(0);
                            break;

                    default:Console.WriteLine("Invalid choice...");
                            Console.WriteLine("Re-Enter...");
                            break;
                }
            }
        }
    }
}
