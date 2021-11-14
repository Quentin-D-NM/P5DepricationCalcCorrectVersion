using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P5DepricationCalc.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace P5DepricationCalc.Data.Models
{
    public class MyAsset : IMyAsset
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double InitValue { get; set; }
        [Required]
        public double SalvageValue { get; set; }
        [Required]
        public int UsefullLife { get; set; }
        [Required]
        public DateTime DateIn { get; set; }
        [Required]
        public DateTime DateOut { get; set; }
        public bool GraphVis { get; set; }
        public double YearlyDeprecation { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " | InitValue: " + InitValue + " | SalvageValue: " + SalvageValue;
            //return base.ToString();
        }
    }
}
