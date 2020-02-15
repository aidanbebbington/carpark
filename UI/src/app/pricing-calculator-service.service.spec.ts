import { TestBed } from '@angular/core/testing';

import { PricingCalculatorServiceService } from './pricing-calculator-service.service';

describe('PricingCalculatorServiceService', () => {
  let service: PricingCalculatorServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PricingCalculatorServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
