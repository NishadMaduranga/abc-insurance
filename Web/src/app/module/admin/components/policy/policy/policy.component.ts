import { Component, OnInit } from '@angular/core';
import { RiskTypes } from 'src/app/models/risk-type';
import { RiskTypesService } from '../../../services/risk-types.service';
import { Policy } from 'src/app/models/policy';

@Component({
  selector: 'app-policy',
  templateUrl: './policy.component.html',
  styleUrls: ['./policy.component.css']
})
export class PolicyComponent implements OnInit {
  riskTypes:RiskTypes[]=[];
  policy:Policy;
  constructor(private riskTypesService: RiskTypesService) { 
    this.policy = new Policy();
  }

  ngOnInit() {
    this.getRiskTypes();
  }

  getRiskTypes() {
    this.riskTypesService.getAllRiskTypes().then(res => {
      this.riskTypes = res;
      this.policy.riskTypes = this.riskTypes;
    });
  }
  save(){
    console.log(this.policy);
  }
  updateSelectedRiskType($event){
    console.log($event);
  }
}
