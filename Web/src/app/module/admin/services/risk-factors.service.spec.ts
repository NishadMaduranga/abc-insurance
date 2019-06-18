import { TestBed } from '@angular/core/testing';

import { RiskFactorsService } from './risk-factors.service';

describe('RiskFactorsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RiskFactorsService = TestBed.get(RiskFactorsService);
    expect(service).toBeTruthy();
  });
});
