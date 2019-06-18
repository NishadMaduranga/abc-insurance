import { Component, OnInit } from '@angular/core';
import { RiskTypes } from 'src/app/models/risk-type';
import { RiskTypesService } from '../../../services/risk-types.service';

@Component({
  selector: 'app-risk-type-list',
  templateUrl: './risk-type-list.component.html',
  styleUrls: ['./risk-type-list.component.css']
})
export class RiskTypeListComponent implements OnInit {

  riskTypes: RiskTypes[] = [];
  constructor(private riskTypesService: RiskTypesService) { }

  ngOnInit() {
    this.getRiskTypes();
  }
  getRiskTypes() {
    this.riskTypesService.getAllRiskTypes().then(res => {
      this.riskTypes = res;
    });
  }

}
