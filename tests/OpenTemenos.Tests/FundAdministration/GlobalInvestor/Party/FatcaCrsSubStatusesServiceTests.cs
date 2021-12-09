using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class FatcaCrsSubStatusesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostFatcaCrsSubStatusesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatusService.PostFatcaCrsSubStatusesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostFatcaCrsSubStatusesAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatusService.PostFatcaCrsSubStatusesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFatcaCrsSubStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.SubStatusService.PutFatcaCrsSubStatusesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFatcaCrsSubStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.SubStatusService.DeleteFatcaCrsSubStatusesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFatcaCrsSubStatusesByInternalIdAsync()
    {
        var result = _client.FatcaCrs.SubStatusService.GetFatcaCrsSubStatusesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFatcaCrsSubStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatusService.PutFatcaCrsSubStatusesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFatcaCrsSubStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatusService.DeleteFatcaCrsSubStatusesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}