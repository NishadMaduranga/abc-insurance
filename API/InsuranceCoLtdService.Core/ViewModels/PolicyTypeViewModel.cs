using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceCoLtdService.Core.ViewModels
{
    public class PolicyTypeViewModel
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }

        public List<RisktypeViewModel> RiskTypes { get; set; }
    }
}
