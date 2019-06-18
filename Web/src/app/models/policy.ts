import { RiskTypes } from './risk-type';

export class Policy{
    id:string;
    code:string=null;
    name:string;
    description:string;
    riskTypes:RiskTypes[];
}