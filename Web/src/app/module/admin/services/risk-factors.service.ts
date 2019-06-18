import { Injectable } from '@angular/core';
import { HttpRequestService } from 'src/app/services/http-request.service';
import { RiskFactors } from 'src/app/models/risk-factor';

@Injectable({
  providedIn: 'root'
})
export class RiskFactorsService {

  constructor(private httpRequestService:HttpRequestService) { }
  async getAllRiskFactors(){
    // try{
    //   const response = await this.httpRequestService.get('');
    //   return response;
    // }
    // catch (e){
    //   console.error(e);
    // }
    return this.getRiskFactors();
  }

  async getRiskFactor(id:string){
    try{
      const response = await this.httpRequestService.get('');
      return response;
    }
    catch (e){
      console.error(e);
    }
  }

  async createRiskFactor(body){
    try{
      const response = await this.httpRequestService.post('',body);
      return response;
    }
    catch (e){
      console.error(e);
    }
  }

  getRiskFactors(){
    const riskFactors: RiskFactors[] = [];
     let r1 = {"id":"1","name":"Age","code":"Age","description":"Age","type":1,"typeDisplay":"Number","validation":null,"selected":false};
     riskFactors.push(r1);
     let r2=  {"id":"1","name":"Alcoholic","code":"Life Style","description":"Are you taking alchohol","type":2,"typeDisplay":"Yes/No","validation":null,"selected":false};
     riskFactors.push(r2);
     return riskFactors;
  }
}
