using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InsuranceCoLtdService.Context.Models
{
    public class RiskType
    {
        [Key]
        public int RiskTypeId { get; set; }
        public string RiskTypeName { get; set; }
        public string RiskTypeDescription { get; set; }
        public virtual ICollection<PolicyRiskTypes> PolicyRiskTypes { get; set; }
        public virtual ICollection<RiskTypeRiskFactor> RiskTypeRiskFactors { get; set; }
    }
}
