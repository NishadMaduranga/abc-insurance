import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RiskFactorListComponent } from './risk-factor-list.component';

describe('RiskFactorListComponent', () => {
  let component: RiskFactorListComponent;
  let fixture: ComponentFixture<RiskFactorListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RiskFactorListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RiskFactorListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
