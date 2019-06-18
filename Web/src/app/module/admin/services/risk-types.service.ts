import { Injectable } from '@angular/core';
import { HttpRequestService } from 'src/app/services/http-request.service';
import { RiskTypes } from 'src/app/models/risk-type';
import { RiskFactors } from 'src/app/models/risk-factor';

@Injectable({
  providedIn: 'root'
})
export class RiskTypesService {

  constructor(private httpRequestService:HttpRequestService) { }
  async getAllRiskTypes(){
    // try{
    //   const response = await this.httpRequestService.get('');
    //   return response;
    // }
    // catch (e){
    //   console.error(e);
    // }
    return this.getRiskTypes();
  }

  async getRiskType(id:string){
    try{
      const response = await this.httpRequestService.get('');
      return response;
    }
    catch (e){
      console.error(e);
    }
  }

  async createRiskType(body){
    try{
      const response = await this.httpRequestService.post('',body);
      return response;
    }
    catch (e){
      console.error(e);
    }
  }

  getRiskTypes(){
    const riskTypes: RiskTypes[] = [];
     let r1 = {"id":"1","code":"Life","name":"Helath","description":"Helath life insurance","riskFactors":this.getRiskFactors(),"selected":false};
     riskTypes.push(r1);
     let r2=  {"id":"1","code":"Life","name":"Life Style","description":"Life Style","riskFactors":this.getRiskFactors(),"selected":false};;
     riskTypes.push(r2);
     return riskTypes;
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
