﻿using Transact;
using Transact.Holding.Entitlements;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class EntitlementsServiceTests : CredentialManagement
{
    private const string EntitlementId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPendingEntitlementsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetPendingEntitlementsAsync(null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetSecurityEntitlementsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetSecurityEntitlementsAsync(EntitlementId, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSecurityEntitlementAsync()
    {
        var entitlementId = string.Empty;
        var payload = new SecurityEntitlement();
        var result = _client.CorporateActionEventManagementService
            .UpdateSecurityEntitlementAsync(entitlementId, payload, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEntitlementBuySellRightsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetEntitlementBuySellRightsAsync(EntitlementId, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateEntitlementBuySellRightsAsync()
    {
        var entitlementId = string.Empty;
        var payload = new EntitlementBuySellRights();
        var result = _client.CorporateActionEventManagementService
            .UpdateEntitlementBuySellRightsAsync(entitlementId, payload, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEntitlementApprovalsAsync()
    {
        var result = _client.CorporateActionEventManagementService
            .GetEntitlementApprovalsAsync(null, null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}