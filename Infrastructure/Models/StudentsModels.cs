using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class StudentsModels
    {
        public int id { get; set; }

        public int dni { get; set; }

        public string names { get; set; }

        public string surnames { get; set; }
        public string courses { get; set; }
        public string years { get; set;  }
    }
}
