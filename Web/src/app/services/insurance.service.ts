import { Injectable } from '@angular/core';
import { HttpRequestService } from './http-request.service';
import { Policy } from '../models/policy';
import { RiskTypes } from '../models/risk-type';
import { RiskFactors } from '../models/risk-factor';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InsuranceService {
  result: any;

  constructor(private httpRequestService:HttpRequestService,private http: HttpClient) { }

  async   getPolicyList(){
    try{
     // const response = await this.httpRequestService.get('');
     // return response;
     return this.ploicyList();
    }
    catch (e){
      console.error(e);
    }
  }

  async getPolicyDetails(type:string){
    try{
     // const response = await this.httpRequestService.get('');
     // return response;
     return this.getPloicies();
    }
    catch (e){
      console.error(e);
    }
  }
  ploicyList(){
    

    // var result = this.http.get('api/values/')
    // .map(response => response.json())
    // .subscribe(result => this.result =result.json());  

    const policies: Policy[] = [];
    let p1 = {"id":"1","code":"","name":"Life","description":"life insurance","riskTypes":null};
    policies.push(p1);
    let p2= {"id":"2","code":"","name":"Vehicle","description":"vehicle insurance","riskTypes":null};
    policies.push(p2);
    return policies;
  }
  getRecommendations()
  {
    return this.http.get("api/values/");
  }

  getPloicies(){
    const policies: Policy[] = [];
     let p1 = {"id":"1","code":"","name":"Life","description":"life insurance","riskTypes":this.getRiskTypes1()};
     policies.push(p1);
     let p2= {"id":"2","code":"","name":"Vehicle","description":"vehicle insurance","riskTypes":this.getRiskTypes2()};
     policies.push(p2);
     return policies;
  }
  getRiskTypes1(){
    const riskTypes: RiskTypes[] = [];
     let r1 = {"id":"1","code":"Life","name":"Helath","description":"Helath life insurance","riskFactors":this.getRiskFactors(),"selected":false};
     riskTypes.push(r1);
     let r2=  {"id":"1","code":"Life","name":"Life Style","description":"Life Style","riskFactors":this.getRiskFactors1(),"selected":false};;
     riskTypes.push(r2);
     return riskTypes;
  }
  getRiskTypes2(){
    const riskTypes: RiskTypes[] = [];
     let r1 = {"id":"1","code":"Life","name":"Helath","description":"Helath life insurance","riskFactors":this.getRiskFactors1(),"selected":false};
     riskTypes.push(r1);
     return riskTypes;
  }
  getRiskFactors(){
    const riskFactors: RiskFactors[] = [];
     let r1 = {"id":"1","name":"Age","code":"Age","description":"Age","type":1,"typeDisplay":"Number","validation":null,"selected":false};
     riskFactors.push(r1);
     let r2=  {"id":"2","name":"Alcoholic","code":"Life Style","description":"Are you taking alchohol","type":2,"typeDisplay":"Yes/No","validation":null,"selected":false};
     riskFactors.push(r2);
     return riskFactors;
  }
  getRiskFactors1(){
    const riskFactors: RiskFactors[] = [];
     let r2=  {"id":"4","name":"Single Or Married","code":"Life Style","description":"Are you taking alchohol","type":2,"typeDisplay":"Yes/No","validation":null,"selected":false};
     riskFactors.push(r2);
     return riskFactors;
  }
}
