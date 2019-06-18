using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InsuranceCoLtdService.Context.Models
{
    public class RiskFactor
    {
        [Key]
        public int RiskFactorId { get; set; }
        public string RiskFactorName { get; set; }
        public string RiskFactorDescription { get; set; }
        public virtual ICollection<RiskTypeRiskFactor> RiskTypeRiskFactors { get; set; }
        public virtual int ValidationId { get; set; }
        public virtual Validation Validation { get; set; }
    }
}
