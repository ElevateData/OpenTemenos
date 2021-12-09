using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.MinLimitsExpiry;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class MinLimitsExpiryServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostMinLimitsExpiryByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .PostMinlimitsexpiryByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostMinLimitsExpiryAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .PostMinlimitsexpiryAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutMinLimitsExpiryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorMinLimitExpiryService
            .PutMinlimitsexpiryAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteMinLimitsExpiryAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorMinLimitExpiryService
            .DeleteMinlimitsexpiryAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetMinLimitsExpiryByInternalIdAsync()
    {
        var result = _client.InvestorMinLimitExpiryService
            .GetMinlimitsexpiryByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
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
            .PutMinlimitsexpiryByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteMinLimitsExpiryByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorMinLimitExpiryService
            .DeleteMinlimitsexpiryByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}