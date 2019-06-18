using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InsuranceCoLtdService.Context.Models
{
   public class PolicyRiskTypes
    {
       
        public int PId { get; set; }
        public  Policy Policy { get; set; }
        
        public int RId { get; set; }
        public  RiskType RiskType { get; set; }
    }
}
