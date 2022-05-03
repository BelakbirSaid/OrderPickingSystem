using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class operaController : ApiController
    {

        
        public HttpResponseMessage Get()
        {
            
            string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";

          

            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"SELECT * FROM [EmpOptimisation].[dbo].[opera]";
                    //string sqlQuery1 = "SELECT   U_emp as Emplacement , ItemCode as Réf, OnHand as QtStock from oitw t1 where t1.WhsCode = '01' and t1.U_emp like '" + emplacement + "%'";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    DataTable dtbl = new DataTable();


                    dataAdapter.Fill(dtbl);


                //
                return Request.CreateResponse(HttpStatusCode.OK, dtbl);

            }
            
            


            


        }


        public string Post(opera op)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    string sqlQuery = @"Insert into [EmpOptimisation].[dbo].[opera] values ('"+op.date_debut+"','"+op.date_fin+"','"+op.Magasin+"','"+op.magasinier+"','"+op.EtatOp+"')";
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

        public string Put(opera op)
        {
            try
            {

                string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = @"Update opera set date_debut = '"+op.date_debut+"', date_fin='"+op.date_fin+"',Magasin='"+op.Magasin+"',magasinier='"+op.magasinier+"',EtatOp='"+op.EtatOp+"' where Nu_op ='"+op.Nu_op+"'";
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


        public string Delete(opera op)
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
