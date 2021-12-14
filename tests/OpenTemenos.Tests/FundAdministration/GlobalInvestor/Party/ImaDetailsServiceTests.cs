using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.ImaDetails;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class ImaDetailServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostImaDetailsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .PostImadetailsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostImaDetailsAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .PostImadetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutImaDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestmentManagementAccountService
            .PutImadetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteImaDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestmentManagementAccountService
            .DeleteImadetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetImaDetailsByInternalIdAsync()
    {
        var result = _client.InvestmentManagementAccountService
            .GetImadetailsByInternalIdAsync(InternalId)
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
            .PutImadetailsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteImaDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestmentManagementAccountService
            .DeleteImadetailsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}