using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace swaggerCore.Controllers
{
    [ServiceFilter(typeof(TokenFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class SchollController : ControllerBase
    {
        SchollService schollService;
        public SchollController()
        {
            schollService = new SchollService();
        }
        // GET api/GetAllClass
        [HttpGet("GetAllClass")]
        public ActionResult<List<Class>> GetAllClass()
        {
            return schollService.GetAllClass();
        }

        [HttpGet("GetAllStudents")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return schollService.GetAllStudents();
        }

        [HttpGet("GetClassByID/{id}")]
        public Class GetClassByID(int id)
        {
            return schollService.GetClassByID(id);
        }

        [HttpGet("GetClassByName/{name}")]
        public Class GetClassByName(string name)
        {
            return schollService.GetClassByName(name);
        }

        [HttpGet("GetStudentByClass/{classID}")]
        public List<Student> GetStudentByClass(int classID)
        {
            return schollService.GetStudentByClass(classID);
        }

        [HttpGet("GetStudentByID/{id}")]
        public Student GetStudentByID(int id)
        {
            return schollService.GetStudentByID(id);
        }

        [HttpGet("GetStudentByName/{id}")]
        public Student GetStudentByName(string name)
        {
            return schollService.GetStudentByName(name);
        }

        [HttpPost("AddStudent")]
        public void AddStudent([FromBody] Student student)
        {
            schollService.AddStudent(student);
        }

        [HttpPost("AddClass")]
        public void AddClass([FromBody] Class _class)
        {
            schollService.AddClass(_class);
        }
    }
}
