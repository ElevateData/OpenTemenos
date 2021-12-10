using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.MinLimitsExpiry;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class MinLimitsExpiryServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostMinLimitsExpiryByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .PostMinlimitsexpiryByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostMinLimitsExpiryAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .PostMinlimitsexpiryAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutMinLimitsExpiryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorMinLimitExpiryService
            .PutMinlimitsexpiryAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteMinLimitsExpiryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorMinLimitExpiryService
            .DeleteMinlimitsexpiryAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetMinLimitsExpiryByInternalIdAsync()
    {
        var result = _client.InvestorMinLimitExpiryService
            .GetMinlimitsexpiryByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutMinLimitsExpiryByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .PutMinlimitsexpiryByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteMinLimitsExpiryByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .DeleteMinlimitsexpiryByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}