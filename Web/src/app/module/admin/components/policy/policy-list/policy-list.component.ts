import { Component, OnInit } from '@angular/core';
import { Policy } from 'src/app/models/policy';
import { PolicyService } from '../../../services/policy.service';

@Component({
  selector: 'app-policy-list',
  templateUrl: './policy-list.component.html',
  styleUrls: ['./policy-list.component.css']
})
export class PolicyListComponent implements OnInit {

  policyList:Policy[]=[];

  constructor(private policyService:PolicyService) { }

  ngOnInit() {
    this.policyService.getAllPolicies().then(res=>{
        this.policyList = res;
        console.log(this.policyList);
    });
  }

  addNewPolicy(){
    console.log('PLease Add a new Pl=olicy');
  }

}
