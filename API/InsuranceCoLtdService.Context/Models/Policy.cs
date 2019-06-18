using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InsuranceCoLtdService.Context.Models
{
   public class Policy
    {
        [Key]
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDescription { get; set; }
        public virtual ICollection<PolicyRiskTypes> PolicyRiskTypes { get; set; }
    }
}
