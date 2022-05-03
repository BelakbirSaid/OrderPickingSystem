using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Table_2OPController : ApiController
    {
        public HttpResponseMessage Get()
        {

            string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"SELECT * FROM [EmpOptimisation].[dbo].[Table_2OP]";
                //string sqlQuery1 = "SELECT   U_emp as Emplacement , ItemCode as Réf, OnHand as QtStock from oitw t1 where t1.WhsCode = '01' and t1.U_emp like '" + emplacement + "%'";

                SqlCommand command = new SqlCommand(sqlQuery, connection);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                DataTable dtbl = new DataTable();


                dataAdapter.Fill(dtbl);


                //
                return Request.CreateResponse(HttpStatusCode.OK, dtbl);

            }







        }


        public string Post(Table_2OP op1)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Insert into [EmpOptimisation].[dbo].[Table_2OP] values ('" + op1.Nu_op + "','" + op1.EmAc + "','" + op1.EmOp + "','" + op1.Quant + "','" + op1.Com+ "','"+op1.EtatRef+"')";
                    //string sqlQuery1 = "SELECT   U_emp as Emplacement , ItemCode as Réf, OnHand as QtStock from oitw t1 where t1.WhsCode = '01' and t1.U_emp like '" + emplacement + "%'";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    DataTable dtbl = new DataTable();


                    dataAdapter.Fill(dtbl);


                    //

                }

                return "Added Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Add!!";
            }
        }


        //update 

        public string Put(Table_2OP op1)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Update opera set Nu_op = '" + op1.Nu_op + "', EmAc='" +op1.EmAc + "',EmOp='" + op1.Com + "',magasinier='" + op.magasinier + "',EtatOp='" + op.EtatOp + "' where Nu_op ='" + op.Nu_op + "'";
                    //string sqlQuery1 = "SELECT   U_emp as Emplacement , ItemCode as Réf, OnHand as QtStock from oitw t1 where t1.WhsCode = '01' and t1.U_emp like '" + emplacement + "%'";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    DataTable dtbl = new DataTable();


                    dataAdapter.Fill(dtbl);


                    //

                }

                return "Added Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Add!!";
            }
        }


        //delete


        public string Delete(Table_2OP op1)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Delete from [EmpOptimisation].[dbo].[opera]  where Nu_op ='" + op.Nu_op + "'";
                    //string sqlQuery1 = "SELECT   U_emp as Emplacement , ItemCode as Réf, OnHand as QtStock from oitw t1 where t1.WhsCode = '01' and t1.U_emp like '" + emplacement + "%'";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    DataTable dtbl = new DataTable();


                    dataAdapter.Fill(dtbl);


                    //

                }

                return "Deleted Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to delete!!";
            }
        }


    }
}
