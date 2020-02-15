using Core.Models.Pricing;

namespace Core.Services.Pricing.Rates
{
    public interface IRate
    {
        bool IsApplicable(PricingRequest request);
        PricingResponse GetPricing(PricingRequest request);
    }
}
