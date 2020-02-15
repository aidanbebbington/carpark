using Core.Extensions;
using Core.Models.Pricing;

namespace Core.Services.Pricing.Rates
{
    public class EarlyBirdRate : IRate
    {
        public bool IsApplicable(PricingRequest request)
        {
            return request.Entry.Day == request.Exit.Day &&
                   request.Entry.IsBetween(6, 9) &&
                   request.Exit.IsBetween(15.5, 23.5);
        }

        public PricingResponse GetPricing(PricingRequest request)
        {
            return new PricingResponse
            {
                Description = "Early Bird",
                TotalPrice = 13
            };
        }
    }
}
