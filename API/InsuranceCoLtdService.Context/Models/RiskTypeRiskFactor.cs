using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InsuranceCoLtdService.Context.Models
{
   public class RiskTypeRiskFactor
    {
  
        public  int RiskTypeId { get; set; }
        public  RiskType RiskType { get; set; }

        
        public  int RiskFactorId { get; set; }
        public  RiskFactor RiskFactor { get; set; }
    }
}
