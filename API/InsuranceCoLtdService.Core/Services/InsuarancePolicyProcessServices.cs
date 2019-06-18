using InsuranceCoLtdService.Context;
using InsuranceCoLtdService.Core.ServiceContracts;
using InsuranceCoLtdService.Core.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCoLtdService.Core.Services
{
    public class InsuarancePolicyProcessServices: IInsuarancePolicyProcessServices
    {
        private  InsurancePolicyContext _context { get; set; }

        public InsuarancePolicyProcessServices(InsurancePolicyContext context)
        {
            this._context = context;
        }

        public async Task<List<PolicyTypeViewModel>> GetAllPolicies()
        {
            List<PolicyTypeViewModel> policyTypes = new List<PolicyTypeViewModel>();
            var polis= _context.Policies.Include(p=>p.PolicyRiskTypes).ToList();
            return policyTypes;
        }
        public async Task<PolicyTypeViewModel> GetPolicy(int id)
        {
            PolicyTypeViewModel policyTypes = new PolicyTypeViewModel();
            var polis = _context.Policies.Include(a=>a.PolicyRiskTypes).Where(a=>a.PolicyId == id);
            return policyTypes;
        }
        public async Task<List<RisktypeViewModel>> GetRiskTypes()
        {
            List<RisktypeViewModel> riskTypeList = new List<RisktypeViewModel>();
            var riskFactors = _context.RiskTypes.ToList().Select(type => new RisktypeViewModel()
            {
                RiskTypeId = type.RiskTypeId,
                RiskTypeName = type.RiskTypeName,
                RiskTypeDescription = type.RiskTypeDescription
            }).ToList();
            return riskTypeList;
        }
        public List<RiskFactorViewModel> GetRiskFactors()
        {
            List<RiskFactorViewModel> riskFactorsList = new List<RiskFactorViewModel>();
            var riskFactors = _context.RiskFactors.Select(type => new RiskFactorViewModel()
            {
                RiskFactorId = type.RiskFactorId,
                RiskFactorName = type.RiskFactorName,
                RiskFactorDescription = type.RiskFactorDescription
            }).ToList();
            return riskFactorsList;
        }
    }
    
    }
