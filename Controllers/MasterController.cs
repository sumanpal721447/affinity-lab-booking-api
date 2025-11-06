using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PATHLAB.Model;
using System.Data.SqlClient;

namespace PATHLAB.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly DBHelper _db;
        public MasterController(DBHelper db) => _db = db;

        [HttpGet("State")]
        public IActionResult GetState()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_State");
            return Ok(result);
        }

        [HttpGet("City")]
        public IActionResult GetCity()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_City");
            return Ok(result);
        }
        [HttpGet("PinCode")]
        public IActionResult GetPinCode()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_PinCode");
            return Ok(result);
        }
        [HttpGet("Partner")]
        public IActionResult GetPartner()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_Partner");
            return Ok(result);
        }
        [HttpGet("LabTest")]
        public IActionResult GetLabTest()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_LabTest");
            return Ok(result);
        }
        [HttpGet("Package")]
        public IActionResult GetPackage()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_Package");
            return Ok(result);
        }
        [HttpGet("DoctorSpecialization")]
        public IActionResult GetDoctorSpecialization()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_DoctorSpecialization");
            return Ok(result);
        }
        [HttpGet("Doctor")]
        public IActionResult GetDoctor()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_Doctor");
            return Ok(result);
        }
        [HttpGet("CustomerFeedback")]
        public IActionResult GetCustomerFeedback()
        {
            var result = _db.ExecuteStoredProcedure("PROC_G_CustomerFeedback");
            return Ok(result);
        }
                
    }
}
