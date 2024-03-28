using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneName { get; set; }
        public string Model { get; set; }
        public int Ram { get; set; }
        public int Memory { get; set; }

    }
}
