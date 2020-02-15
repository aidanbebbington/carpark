using Core.Models.Pricing;
using Core.Services.Pricing;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IPricingService _service;

        public PricingController(IPricingService service)
        {
            _service = service;
        }

        [HttpPost]
        public PricingResponse GetPricing(PricingRequest request)
        {
            return _service.GetPricing(request);
        }
    }
}