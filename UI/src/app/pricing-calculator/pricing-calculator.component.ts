import { Component, OnInit } from '@angular/core';
import { PricingCalculatorService, PricingResponse } from '../pricing-calculator-service.service';

@Component({
  selector: 'app-pricing-calculator',
  templateUrl: './pricing-calculator.component.html',
  styleUrls: ['./pricing-calculator.component.sass']
})
export class PricingCalculatorComponent implements OnInit {

  pricingResponse : PricingResponse;
  entryTime = {hour: 13, minute: 30};
  entryDate : Date;
  exitTime = {hour: 14, minute: 30};
  exitDate : Date;

  constructor(private service: PricingCalculatorService) { }

  ngOnInit(): void {
  }

  calculate(): void {
    this.service.getPricing().subscribe(pricingResponse => {
      this.pricingResponse = pricingResponse;
    });
  }

}
