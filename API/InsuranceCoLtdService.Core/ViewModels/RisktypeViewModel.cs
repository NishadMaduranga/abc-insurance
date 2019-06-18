using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceCoLtdService.Core.ViewModels
{
   public class RisktypeViewModel
    {
        public int RiskTypeId { get; set; }
        public string RiskTypeName { get; set; }
        public string RiskTypeDescription { get; set; }
        public List<RiskFactorViewModel> RiskFactors { get; set; }
    }
}
