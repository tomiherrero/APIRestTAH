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
    }
}
