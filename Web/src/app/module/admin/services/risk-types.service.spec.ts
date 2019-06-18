import { TestBed } from '@angular/core/testing';

import { RiskTypesService } from './risk-types.service';

describe('RiskTypesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RiskTypesService = TestBed.get(RiskTypesService);
    expect(service).toBeTruthy();
  });
});
