﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTracker.DataAcess.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string Customer { get; set; }

        public bool Current { get; set; }
    }
}
