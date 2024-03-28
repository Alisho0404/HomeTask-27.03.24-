﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public string Population { get; set; }
        public string Language { get; set; }
    }
}
