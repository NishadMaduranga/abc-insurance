import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminComponent } from './admin.component';
import { AdminRoutingModule } from './admin-routing.module';
import { PolicyService } from './services/policy.service';
import { HttpClientModule } from '@angular/common/http';
import { PolicyListComponent } from './components/policy/policy-list/policy-list.component';
import { RiskTypeListComponent } from './components/risk-type/risk-type-list/risk-type-list.component';
import { PolicyComponent } from './components/policy/policy/policy.component';
import { FormsModule } from '@angular/forms';
import { RiskTypesService } from './services/risk-types.service';
import { RiskFactorsService } from './services/risk-factors.service';
import { RiskFactorListComponent } from './components/risk-factor/risk-factor-list/risk-factor-list.component';


@NgModule({
  declarations: [PolicyListComponent, RiskTypeListComponent,RiskFactorListComponent, AdminComponent,PolicyComponent],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule
  ],
  providers:[PolicyService,RiskTypesService,RiskFactorsService]
})
export class AdminModule { }
