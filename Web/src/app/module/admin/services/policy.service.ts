import { Injectable } from '@angular/core';
import { HttpRequestService } from 'src/app/services/http-request.service';
import { Policy } from 'src/app/models/policy';
import { RiskTypes } from 'src/app/models/risk-type';

@Injectable({
  providedIn: 'root'
})
export class PolicyService {

  constructor(private httpRequestService:HttpRequestService) { }

  async getAllPolicies(){
    try{
     // const response = await this.httpRequestService.get('');
     // return response;
     return this.getPloicies();
    }
    catch (e){
      console.error(e);
    }
  }

  async createPolicy(body){
    try{
      const response = await this.httpRequestService.post('',body);
      return response;
    }
    catch (e){
      console.error(e);
    }
  }

  getPloicies(){
    const policies: Policy[] = [];
     let p1 = {"id":"1","code":"","name":"Life","description":"life insurance","riskTypes":this.getRiskTypes()};
     policies.push(p1);
     let p2= {"id":"2","code":"","name":"Vehicle","description":"vehicle insurance","riskTypes":this.getRiskTypes()};
     policies.push(p2);
     return policies;
  }
  getRiskTypes(){
    const riskTypes: RiskTypes[] = [];
     let r1 = {"id":"1","code":"Life","name":"Helath","description":"Helath life insurance","riskFactors":null,"selected":false};
     riskTypes.push(r1);
     let r2=  {"id":"1","code":"Life","name":"Life Style","description":"Life Style","riskFactors":null,"selected":false};;
     riskTypes.push(r2);
     return riskTypes;
  }
}
