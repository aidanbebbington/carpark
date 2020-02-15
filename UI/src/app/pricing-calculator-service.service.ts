import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})

export class PricingCalculatorService {

  constructor(private http: HttpClient) { }

  getPricing() : Observable<HttpResponse<PricingResponse>> {
    return this.http.post<PricingResponse>('http://localhost:44328/v1/Pricing', {
      entry: "2020-02-15T07:12:23.654Z",
      exit: "2020-02-15T07:12:23.654Z"
    }, { observe: 'response' });
  }
}

export class PricingResponse {
  public description: string;
  public totalPrice: number;
}
