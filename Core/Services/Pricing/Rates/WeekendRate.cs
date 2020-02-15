using System;
using Core.Extensions;
using Core.Models.Pricing;

namespace Core.Services.Pricing.Rates
{
    public class WeekendRate : IRate
    {
        public bool IsApplicable(PricingRequest request)
        {
            return request.Entry.IsWeekend() &&
                   request.Exit.IsWeekend() &&
                   request.Exit - request.Entry < TimeSpan.FromDays(2);
        }

        public PricingResponse GetPricing(PricingRequest request)
        {
            return new PricingResponse
            {
                Description = "Weekend Rate",
                TotalPrice = 10
            };
        }
    }
}
