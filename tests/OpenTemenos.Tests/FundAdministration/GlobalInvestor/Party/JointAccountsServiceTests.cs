using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.JointAccounts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class JointAccountServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostJointAccountsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.JointAccountService.PostJointaccountsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostJointAccountsAsync()
    {
        var payload = new _0Payload();
        var result = _client.JointAccountService.PostJointaccountsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutJointAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.JointAccountService.PutJointaccountsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteJointAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.JointAccountService.DeleteJointaccountsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetJointAccountsByInternalIdAsync()
    {
        var result = _client.JointAccountService
            .GetJointaccountsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutJointAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.JointAccountService
            .PutJointaccountsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteJointAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.JointAccountService
            .DeleteJointaccountsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}