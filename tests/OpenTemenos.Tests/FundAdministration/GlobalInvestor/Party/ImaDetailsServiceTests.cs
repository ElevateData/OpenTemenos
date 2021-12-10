using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ImaDetails;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ImaDetailsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostImaDetailsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .PostImadetailsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostImaDetailsAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .PostImadetailsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutImaDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestmentManagementAccountService
            .PutImadetailsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteImaDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestmentManagementAccountService
            .DeleteImadetailsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetImaDetailsByInternalIdAsync()
    {
        var result = _client.InvestmentManagementAccountService
            .GetImadetailsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutImaDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .PutImadetailsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteImaDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .DeleteImadetailsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}