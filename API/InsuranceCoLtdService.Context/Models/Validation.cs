using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InsuranceCoLtdService.Context.Models
{
   public class Validation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
