using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaCrsStatuses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FatcaCrsStatuseServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsStatusesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatuService
            .PostFatcaCrsStatusesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsStatusesAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatuService.PostFatcaCrsStatusesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.StatuService.PutFatcaCrsStatusesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsStatusesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.StatuService.DeleteFatcaCrsStatusesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFatcaCrsStatusesByInternalIdAsync()
    {
        var result = _client.FatcaCrs.StatuService
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
        var result = _client.FatcaCrs.StatuService
            .PutFatcaCrsStatusesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsStatusesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.StatuService
            .DeleteFatcaCrsStatusesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}