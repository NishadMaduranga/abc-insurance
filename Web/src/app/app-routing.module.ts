import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { AppComponent } from './app.component';
import { AdminComponent } from './components/admin/admin.component'
import { InsuranceComponent } from './components/insurance/insurance.component';

const routes: Routes = [
  {path: 'home',component: HomeComponent},
  {path: 'insurance',component: InsuranceComponent},
  {path:'admin',component:AdminComponent,children:[{path:'',loadChildren:'./module/admin/admin.module#AdminModule'}]}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
