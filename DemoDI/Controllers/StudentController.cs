using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoDI.Services;
using DemoDI.Services.Dt;
using DemoDI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        public IActionResult Index([FromServices]IStudentServices studentServices)
        {
            var student = _studentServices.GetAll();
            return View(student);
        }
        
    }
}
