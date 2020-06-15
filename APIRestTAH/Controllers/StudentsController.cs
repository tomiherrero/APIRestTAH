using Infrastructure.Contexts;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRestTAH.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase

    {
        private readonly StudentsContexts context; 

        public StudentsController(StudentsContexts context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StudentsModels>> Get()
        {
            return context.Student.ToList();
        }

        [HttpPost]
        public ActionResult Post([FromBody] StudentsModels studentModel)
        {
            context.Student.Add(studentModel);
            context.SaveChanges();
            // CreatedAtRouteResult = funcion de ASP.Net para redireccionar lo que agrega 
            return new CreatedAtRouteResult("Student", new { id = studentModel.id }, studentModel);
        }
    }
}
