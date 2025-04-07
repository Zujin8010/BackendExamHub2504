using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mercuryfire.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MercuryfireController : Controller
    {
        private readonly string _connectionString;

        public MercuryfireController(IConfiguration connectionString)
        {
            _connectionString = connectionString.GetConnectionString("DBconnectionString");
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] ACPDRequest input)
        {
            string storedProcedure = "dbo.usp_CreateACPD";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ACPD_Cname", input.ACPD_Cname);
                        command.Parameters.AddWithValue("@ACPD_Ename", input.ACPD_Ename);
                        command.Parameters.AddWithValue("@ACPD_Sname", input.ACPD_Sname);
                        command.Parameters.AddWithValue("@ACPD_Email", input.ACPD_Email);
                        command.Parameters.AddWithValue("@ACPD_Status", input.ACPD_Status);
                        command.Parameters.AddWithValue("@ACPD_Stop", input.ACPD_Stop);
                        command.Parameters.AddWithValue("@ACPD_StopMemo", input.ACPD_StopMemo);
                        command.Parameters.AddWithValue("@ACPD_LoginID", input.ACPD_LoginID);
                        command.Parameters.AddWithValue("@ACPD_LoginPWD", input.ACPD_LoginPWD);
                        command.Parameters.AddWithValue("@ACPD_Memo", input.ACPD_Memo);
                        command.Parameters.AddWithValue("@ACPD_NowID", input.ACPD_NowID);

                        SqlParameter outputACPD_SID = new SqlParameter("@ACPD_SID", System.Data.SqlDbType.Char, 20)
                        {
                            Direction = System.Data.ParameterDirection.Output
                        };
                        command.Parameters.Add(outputACPD_SID);
                        command.ExecuteNonQuery();
                        
                        string acpdSID = outputACPD_SID.Value.ToString();

                        return Ok($"Create Complete, ACPD_SID: {acpdSID}");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("Read")]
        public IActionResult Read([FromBody] ACPDRequest input)
        {
            string storedProcedure = "dbo.usp_ReadACPD";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Name", input.ACPD_Sname);

                        return Ok($"Create Complete");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] ACPDRequest input)
        {
            string storedProcedure = "dbo.usp_UpdateACPD";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Name", input.ACPD_Sname);

                        return Ok($"Create Complete");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpDelete("Delete")]
        public IActionResult Delete([FromBody] ACPDRequest input)
        {
            string storedProcedure = "dbo.usp_DeleteACPD";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Name", input.ACPD_Sname);

                        return Ok($"Create Complete");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
