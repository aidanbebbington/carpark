using Core.Ioc;
using Core.Models.Pricing;
using Core.Services.Pricing;
using Core.Services.Pricing.Rates;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Xunit;

namespace Test.Services.Pricing
{
    public class PricingServiceTests
    {
        private readonly IServiceProvider _serviceProvider;

        public PricingServiceTests()
        {
            var services = new ServiceCollection();
            services.ConfigureServices();
            _serviceProvider = services.BuildServiceProvider();
        }

        [Fact]
        public void GivenServicesConfigured_WhenGetServices_ThenAllServicesReceived()
        {
            _serviceProvider.GetServices<IRate>().Count().Should().Be(4);
            _serviceProvider.GetService<IPricingService>().Should().NotBeNull();
        }

        [Theory]
        [InlineData("Wednesday 30 minutes", "2020-01-01T10:00", "2020-01-01T10:30", "Standard Rate", 5)]
        [InlineData("Wednesday 5 hours", "2020-01-01T10:00", "2020-01-01T15:00", "Standard Rate", 20)]
        [InlineData("Saturday 30 minutes", "2020-01-04T10:00", "2020-01-04T10:30", "Standard Rate", 5)]
        [InlineData("Saturday 5 hours", "2020-01-04T10:00", "2020-01-04T15:00", "Weekend Rate", 10)]
        public void TestGetPricing(string description, string entry, string exit, string expectedDescription, decimal expectedTotalCost)
        {
            var service = _serviceProvider.GetService<IPricingService>();

            var pricingResponse = service.GetPricing(new PricingRequest
            {
                Entry = DateTime.Parse(entry),
                Exit = DateTime.Parse(exit)
            });

            pricingResponse.Description.Should().Be(expectedDescription);
            pricingResponse.TotalPrice.Should().Be(expectedTotalCost);
        }
    }
}
