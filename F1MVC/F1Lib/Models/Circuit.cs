using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Lib.Models
{
    public class Circuit
    {
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        public double? Latitude { get; set; }

        [DataType(DataType.Url)]
        [StringLength(250, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        public double? Longitude { get; set; }

        public string? Wiki { get; set; } = string.Empty;

        public Country? Country { get; set; }

        public List<Result> Races { get; set; }
    }

}