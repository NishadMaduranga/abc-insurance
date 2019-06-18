
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin.component';
import { PolicyListComponent } from './components/policy/policy-list/policy-list.component';
import { RiskTypeListComponent } from './components/risk-type/risk-type-list/risk-type-list.component';
import { RiskFactorListComponent } from './components/risk-factor/risk-factor-list/risk-factor-list.component';

const adminRoutes: Routes = [
    { path: '', component: AdminComponent },
    {path: 'policy', component: PolicyListComponent},
    {path:'risktypes',component:RiskTypeListComponent},
    {path:'riskfactors',component:RiskFactorListComponent}
];
@NgModule({
  imports: [
    RouterModule.forChild(adminRoutes)
  ],
  exports: [
    RouterModule
  ]
})
export class AdminRoutingModule { }
