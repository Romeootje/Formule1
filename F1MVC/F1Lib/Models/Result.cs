using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Lib.Models
{
    public class Result
    {
        public int ID { get; set; }

        [Display(Name = "Jaar")]
        public int Year { get; set; }

        [Display(Name = "#")]
        public byte Racenumber { get; set; }

        [Display(Name = "Datum")]
        public DateTime? Date { get; set; }

        [Display(Name = "Rondes")]
        public byte Rounds { get; set; }

        [Display(Name = "Tijd")]
        public string Time { get; set; } = string.Empty;

        public Driver Driver { get; set; }
        public Grandprix GrandPrix { get; set; }
        public Circuit Circuit { get; set; }
        public Team Team { get; set; }
    }

}
