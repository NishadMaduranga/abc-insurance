import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RiskTypeListComponent } from './risk-type-list.component';

describe('RiskTypeListComponent', () => {
  let component: RiskTypeListComponent;
  let fixture: ComponentFixture<RiskTypeListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RiskTypeListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RiskTypeListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
