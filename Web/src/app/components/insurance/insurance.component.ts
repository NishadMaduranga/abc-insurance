import { Component, OnInit } from '@angular/core';
import { InsuranceService } from 'src/app/services/insurance.service';
import { Policy } from 'src/app/models/policy';

@Component({
  selector: 'app-insurance',
  templateUrl: './insurance.component.html',
  styleUrls: ['./insurance.component.css']
})
export class InsuranceComponent implements OnInit {

  policy:Policy[]=[];
  selectedPolicy:string;
  policyDetails:Policy;
  constructor(private insuranceService:InsuranceService) { }

  ngOnInit() {
    this.getPolicyList();
  }
  getPolicyList(){
    const insuranceTypes = this.insuranceService.getPolicyList().then(res=>{
      this.policy = res;
    });
  }
  onChange(policyType) {
    console.log(policyType);
    this.getPolicyRiskTypes(policyType);
  }
  getPolicyRiskTypes(policyType){
    const insuranceTypes = this.insuranceService.getPolicyDetails(policyType).then(res=>{
      if(policyType == 1){
        this.policyDetails = res[0];
      }
      if(policyType == 2){
        this.policyDetails = res[1];
      }
      console.log(this.policyDetails);
    });
  }
}
