using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Included Extrenally
using System.Data;//Included Externally

namespace ADO_CourseExample_DisconnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                char ch;

                SqlConnection conn = new SqlConnection("Server=.;Database=OrganizationDB; trusted_connection = true");
                SqlCommand cmd = new SqlCommand("Select * from Course",conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder buider = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Course");
                DataTable tab = ds.Tables["Course"];

                do
                {
                    Console.WriteLine("*******************Menu*******************");
                    Console.WriteLine("1.Print All Courses");
                    Console.WriteLine("2.Print Course based on Course Id");
                    Console.WriteLine("3.Insert a new Course Record");
                    Console.WriteLine("4.Update Course Record");
                    Console.WriteLine("5.Delete Course Record");
                    Console.WriteLine("Enter your choice:");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: Console.WriteLine("The required course details are as follows:");
                                foreach (DataRow ro in tab.Rows)
                                {
                                    Console.WriteLine(ro[0].ToString()+"--"+ro[1].ToString()+"--"+ro[2].ToString()+"--"+ro[3].ToString());
                                }
                                break;

                        case 2: Console.WriteLine("Required Course Details absed on Course ID:");
                                Console.WriteLine("Enter CourseID:");
                                int cid = Convert.ToInt32(Console.ReadLine());
                                DataRow[] rows = tab.Select("CourseID="+cid);
                                foreach (DataRow ro in rows)
                                {
                                    Console.WriteLine(ro[0].ToString() + "--" + ro[1].ToString() + "--" + ro[2].ToString() + "--" + ro[3].ToString());
                                }
                                break;
                                
                        case 3: Console.WriteLine("Inserting Record Into The Table:");
                                Console.WriteLine("Enter CourseID:");
                                int cid2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Course Name:");
                                string cname2 = Console.ReadLine();
                                Console.WriteLine("Enter Instructor Name:");
                                string iname2 = Console.ReadLine();
                                Console.WriteLine("Enter Fees:");
                                double fees2 = Convert.ToDouble(Console.ReadLine());

                                DataRow NewRow = tab.NewRow();
                                NewRow["CourseId"] = cid2;
                                NewRow["CourseName"] = cname2;
                                NewRow["Instructor"] = iname2;
                                NewRow["fees"] = fees2;
                                tab.Rows.Add(NewRow);
                                adapter.Update(tab);//Data will be updated into original table
                                Console.WriteLine("Record Inserted Successfully");
                                break;

                        case 4: Console.WriteLine("Updating A Record From The Table:");
                                Console.WriteLine("Enter CourseID:");
                                int cid3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Course Name:");
                                string cname3 = Console.ReadLine();
                                Console.WriteLine("Enter Instructor Name:");
                                string iname3 = Console.ReadLine();
                                Console.WriteLine("Enter Fees:");
                                double fees3 = Convert.ToDouble(Console.ReadLine());

                                DataRow[] row = tab.Select("CourseID=" + cid3);
                                DataRow RowUp = row[0];

                                RowUp["CourseName"] = cname3;
                                RowUp["Instructor"] = iname3;
                                RowUp["fees"] = fees3;
                            
                                adapter.Update(tab);
                                Console.WriteLine("Record Updated Successfully");
                                break;
                        case 5: Console.WriteLine("Deleting a Record From The Table:");
                                Console.WriteLine("Enter CourseID:");
                                int cid4 = Convert.ToInt32(Console.ReadLine());

                                DataRow[] RowDel = tab.Select("CourseID="+cid4);
                                DataRow RowDelete = RowDel[0];
                                RowDelete.Delete();
                                adapter.Update(ds,"Course");
                                Console.WriteLine("Record Successfully Deleted");
                                break;
                        default:Console.WriteLine("Invalid Choice");
                                break;
                    }
                    Console.WriteLine("Do you wish to continue?(Y or y)");
                    ch = Convert.ToChar(Console.ReadLine());

                } while (ch=='Y' || ch=='y');

            }

            catch (SqlException ex)
            {
                Console.WriteLine("Error Message:"+ex.Message);
                //throw;
            }
             
        }
    }
}
