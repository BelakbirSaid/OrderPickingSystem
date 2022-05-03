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
    public class opera1Controller : ApiController
    {


        public HttpResponseMessage Get()
        {

            string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"SELECT * FROM [EmpOptimisation].[dbo].[opera1]";
                
                SqlCommand command = new SqlCommand(sqlQuery, connection);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                DataTable dtbl = new DataTable();


                dataAdapter.Fill(dtbl);


                return Request.CreateResponse(HttpStatusCode.OK, dtbl);

            }



        }


        public string Post(opera1 op1)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Insert into [EmpOptimisation].[dbo].[opera1] values ('" + op1.Nu_op + "','" + op1.refe + "','"+op1.refedes+"','" + op1.EmAc + "','" + op1.EmOp + "','" + op1.Quant + "','" + op1.QuantMax + "','"+op1.EtatRef+"')";
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

        public string Put(opera1 op1)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Update opera set Nu_op = '" + op1.Nu_op + "', refe='" + op1.refe + "',refedes='" + op1.refedes + "',EmAc='" + op1.EmAc + "',EmOp='" + op1.EmOp + "',Quant ='"+op1.Quant+ "',QuantMax = '"+ op1.QuantMax+ "',EtatRef ='"+op1.EtatRef+ "' where  refe='" + op1.refe + "'";
                    //string sqlQuery1 = "SELECT   U_emp as Emplacement , ItemCode as Réf, OnHand as QtStock from oitw t1 where t1.WhsCode = '01' and t1.U_emp like '" + emplacement + "%'";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    DataTable dtbl = new DataTable();


                    dataAdapter.Fill(dtbl);


                    //

                }

                return "updated Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to updated!!";
            }
        }


        //delete


        public string Delete(opera1 op1)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Delete from [EmpOptimisation].[dbo].[opera1]  where refe='" + op1.refe + "'";
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
