using Core.Models.Pricing;
using Core.Services.Pricing.Rates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Pricing
{
    public interface IPricingService
    {
        PricingResponse GetPricing(PricingRequest request);
    }

    public class PricingService : IPricingService
    {
        private readonly IEnumerable<IRate> _rates;

        public PricingService(IEnumerable<IRate> rates)
        {
            _rates = rates;
        }

        public PricingResponse GetPricing(PricingRequest request)
        {
            if (request.Exit < request.Entry)
            {
                // AJB: implement fluid validation
                throw new Exception("Entry must be earlier than Exit");
            }

            return _rates
                .Where(x => x.IsApplicable(request))
                .Select(x => x.GetPricing(request))
                .OrderBy(x => x.TotalPrice)
                .First();
        }
    }
}
