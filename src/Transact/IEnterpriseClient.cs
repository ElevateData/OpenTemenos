using Transact.Enterprise.Pricings;

namespace Transact;

/// <summary>
/// Enterprise product pricing
/// </summary>
public interface IEnterpriseClient
{
    public IPricingService EnterpriseProductPricingService { get; }
}