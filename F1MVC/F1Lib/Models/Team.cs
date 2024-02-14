using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Lib.Models
{
    public class Team
    {
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        [DataType(DataType.Url)]
        [StringLength(250, ErrorMessage = "Maximumlengte van {0} is {1} tekens")]
        [Display(Name = "Wiki pagina")]
        public string? Wiki { get; set; } = string.Empty;

        public Country? Country { get; set; }

        public List<Result> Races { get; set; } 
    }

}
