using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //[HttpGet]
        //public string GetName()
        //{
        //    return "Ali";
        //}

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new string[] { "Ali", "Cavid", "Cinare", "Elcan" });
        }

        [HttpGet]
        //[Route("GetEmployeeByTestId")]
        public IActionResult GetById(int? id)
        {
            if (id is null) return BadRequest();

            return Ok("Ali - " + " " + id);
        }
    }
}