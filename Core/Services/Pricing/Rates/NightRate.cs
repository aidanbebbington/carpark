using System;
using Core.Extensions;
using Core.Models.Pricing;

namespace Core.Services.Pricing.Rates
{
    public class NightRate : IRate
    {
        public bool IsApplicable(PricingRequest request)
        {
            return request.Entry.DayOfWeek != DayOfWeek.Saturday &&
                   request.Entry.DayOfWeek != DayOfWeek.Sunday &&
                   request.Entry.IsBetween(18, 24) &&
                   request.Exit.IsBetween(18, 6) &&
                   (
                       request.Exit.Day == request.Entry.Day ||
                       request.Exit.Day == request.Entry.Day + 1
                   );
        }

        public PricingResponse GetPricing(PricingRequest request)
        {
            return new PricingResponse
            {
                Description = "Night Rate",
                TotalPrice = 6.5m
            };
        }
    }
}
