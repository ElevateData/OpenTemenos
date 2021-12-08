using Transact.Enterprise;
using Transact.Enterprise.Pricing;

namespace Transact;

public class EnterpriseClient : IEnterpriseClient
{
    private readonly HttpClient _httpClient;

    public EnterpriseClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IPricingService EnterpriseProductPricingService => new PricingService(_httpClient);
}
