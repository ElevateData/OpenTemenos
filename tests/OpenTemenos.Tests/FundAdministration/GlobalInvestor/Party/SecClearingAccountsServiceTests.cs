using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.SecClearingAccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class SecClearingAccountsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostSecClearingAccountsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService.PostSecclearingaccountsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostSecClearingAccountsAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService.PostSecclearingaccountsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutSecClearingAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityClearingAccountService.PutSecclearingaccountsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteSecClearingAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityClearingAccountService.DeleteSecclearingaccountsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecClearingAccountsByInternalIdAsync()
    {
        var result = _client.SecurityClearingAccountService.GetSecclearingaccountsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutSecClearingAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService.PutSecclearingaccountsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteSecClearingAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityClearingAccountService.DeleteSecclearingaccountsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}