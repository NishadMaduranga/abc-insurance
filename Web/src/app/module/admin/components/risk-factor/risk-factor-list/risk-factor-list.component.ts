import { Component, OnInit } from '@angular/core';
import { RiskFactors } from 'src/app/models/risk-factor';
import { RiskFactorsService } from '../../../services/risk-factors.service';

@Component({
  selector: 'app-risk-factor-list',
  templateUrl: './risk-factor-list.component.html',
  styleUrls: ['./risk-factor-list.component.css']
})
export class RiskFactorListComponent implements OnInit {

  riskFactors: RiskFactors[] = [];
  constructor(private riskFactorsService: RiskFactorsService) { }

  ngOnInit() {
    this.getRiskFactors();
  }
  getRiskFactors() {
    this.riskFactorsService.getAllRiskFactors().then(res => {
      this.riskFactors = res;
    });
  }

}
