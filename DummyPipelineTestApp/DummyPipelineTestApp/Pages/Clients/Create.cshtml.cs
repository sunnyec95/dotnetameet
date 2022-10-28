using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace DummyPipelineTestApp.Pages.Clients
{
    public class CreateModel : PageModel
    {
        public IndexModel.ClientInfo clientInfo = new IndexModel.ClientInfo();
        public String errorMessage = "";
        public String sucessMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            clientInfo.name = Request.Form["name"];
            clientInfo.email = Request.Form["email"];
            clientInfo.phone = Request.Form["phone"];
            clientInfo.address = Request.Form["address"];

            if (clientInfo.name.Length == 0 || clientInfo.email.Length == 0 || clientInfo.phone.Length == 0 ||
                    clientInfo.address.Length == 0)
            {
                errorMessage = "Fill all Feilds";
                return;
            }

            clientInfo.name = ""; clientInfo.email = ""; clientInfo.phone = ""; clientInfo.address = "";
            sucessMessage = "Added";
            
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO Clients" +
                        "(name, email, phone, address) VALUES" +
                        "(@name, @email, @phone, @address);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", clientInfo.name);
                        command.Parameters.AddWithValue("@email", clientInfo.email);
                        command.Parameters.AddWithValue("@phone", clientInfo.phone);
                        command.Parameters.AddWithValue("@address", clientInfo.address);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                
            }

            Response.Redirect("/Clients/Index");
        }
    }
}
