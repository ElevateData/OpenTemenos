using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.SecClearingAccounts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class SecClearingAccountsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecClearingAccountsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService
            .PostSecclearingaccountsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecClearingAccountsAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService
            .PostSecclearingaccountsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecClearingAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityClearingAccountService
            .PutSecclearingaccountsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecClearingAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityClearingAccountService
            .DeleteSecclearingaccountsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecClearingAccountsByInternalIdAsync()
    {
        var result = _client.SecurityClearingAccountService
            .GetSecclearingaccountsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecClearingAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService
            .PutSecclearingaccountsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecClearingAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService
            .DeleteSecclearingaccountsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}