using System;
using Core.Models.Pricing;

namespace Core.Services.Pricing.Rates
{
    public class StandardRate : IRate
    {
        private const decimal HourlyRate = 5;
        private const decimal DailyRate = 20;

        public bool IsApplicable(PricingRequest request)
        {
            return true;
        }

        public PricingResponse GetPricing(PricingRequest request)
        {
            var hourlyCost = CalculateRate(request, x => x.TotalHours, HourlyRate);

            var dailyCost = CalculateRate(request, x => x.TotalDays, DailyRate);

            return new PricingResponse
            {
                Description = "Standard Rate",
                TotalPrice = Math.Min(hourlyCost, dailyCost)
            };
        }

        private decimal CalculateRate(PricingRequest request, Func<TimeSpan, double> selectFunc, decimal rate)
        {
            var duration = Math.Truncate(selectFunc(request.Exit - request.Entry));

            return (Convert.ToDecimal(duration) + 1) * rate;
        }
    }
}
