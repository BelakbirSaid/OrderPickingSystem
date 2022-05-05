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
    public class DetailOpController : ApiController
    {
       
        public HttpResponseMessage Get(DetailOp detailOp)
        {

            string connectionString = "Server=(localdb)\\MyInstance1;Integrated Security=true; Database = EmpOptimisation;";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"SELECT * FROM [EmpOptimisation].[dbo].[opera1] WHERE Nu_op LIKE '"+detailOp.Nu_op+"'";
                //change query to create new custom aip services 

                SqlCommand command = new SqlCommand(sqlQuery, connection);


                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                DataTable dtbl = new DataTable();


                dataAdapter.Fill(dtbl);


                //
                return Request.CreateResponse(HttpStatusCode.OK, dtbl);

            }



        }
    }
}
