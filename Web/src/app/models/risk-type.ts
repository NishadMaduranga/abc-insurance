import { RiskFactors } from './risk-factor';

export class RiskTypes{
    id:string;
    code:string=null;
    name:string=null;
    description:string=null;
    riskFactors:RiskFactors[]=[];
    selected:boolean;
}