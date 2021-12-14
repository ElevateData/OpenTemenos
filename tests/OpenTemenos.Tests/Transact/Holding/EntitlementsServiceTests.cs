using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Holding.Entitlements;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[TestCategory("Transact")]
public class EntitlementServiceTests : CredentialManagement
{
    private const string EntitlementId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPendingEntitlementsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetPendingEntitlementsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSecurityEntitlementsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetSecurityEntitlementsAsync(EntitlementId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSecurityEntitlementAsync()
    {
        var entitlementId = string.Empty;
        var payload = new SecurityEntitlement();
        var result = _client.CorporateActionEventManagementService
            .UpdateSecurityEntitlementAsync(entitlementId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEntitlementBuySellRightsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetEntitlementBuySellRightsAsync(EntitlementId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateEntitlementBuySellRightsAsync()
    {
        var entitlementId = string.Empty;
        var payload = new EntitlementBuySellRights();
        var result = _client.CorporateActionEventManagementService
            .UpdateEntitlementBuySellRightsAsync(entitlementId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEntitlementApprovalsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetEntitlementApprovalsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}