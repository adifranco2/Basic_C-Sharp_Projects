﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step451
{
    class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
