using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaCrsSubStatuses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FatcaCrsSubStatuseServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsSubStatusesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatuService
            .PostFatcaCrsSubStatusesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsSubStatusesAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatuService
            .PostFatcaCrsSubStatusesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsSubStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.SubStatuService
            .PutFatcaCrsSubStatusesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsSubStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.SubStatuService
            .DeleteFatcaCrsSubStatusesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFatcaCrsSubStatusesByInternalIdAsync()
    {
        var result = _client.FatcaCrs.SubStatuService
            .GetFatcaCrsSubStatusesByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsSubStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatuService
            .PutFatcaCrsSubStatusesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsSubStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.SubStatuService
            .DeleteFatcaCrsSubStatusesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}