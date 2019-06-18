using InsuranceCoLtdService.Context;
using InsuranceCoLtdService.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCoLtdService.Core.ServiceContracts
{
   public interface IInsuarancePolicyProcessServices
    {
       Task<List<PolicyTypeViewModel>> GetAllPolicies();
       Task<PolicyTypeViewModel> GetPolicy(int id);
       Task<List<RisktypeViewModel>> GetRiskTypes();
       List<RiskFactorViewModel> GetRiskFactors();

    }
}
