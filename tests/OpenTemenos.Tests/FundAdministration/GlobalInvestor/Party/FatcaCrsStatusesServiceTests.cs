using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class FatcaCrsStatusesServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsStatusesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatusService
            .PostFatcaCrsStatusesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsStatusesAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatusService.PostFatcaCrsStatusesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.StatusService.PutFatcaCrsStatusesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.StatusService.DeleteFatcaCrsStatusesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFatcaCrsStatusesByInternalIdAsync()
    {
        var result = _client.FatcaCrs.StatusService
            .GetFatcaCrsStatusesByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatusService
            .PutFatcaCrsStatusesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatusService
            .DeleteFatcaCrsStatusesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}