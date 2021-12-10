using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Clients;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class ClientServiceTests : CredentialManagement
{
    private const string ClientId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetClientAsync()
    {
        var result = _client.InvestorService.GetClientAsync()
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostClientAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorService.PostClientAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutClientAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorService.PutClientAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteClientAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorService.DeleteClientAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetClientByClientIdAsync()
    {
        var result = _client.InvestorService
            .GetClientByClientIdAsync(ClientId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutClientByInternalIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorService
            .PutClientByinternalIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteClientByClientIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorService
            .DeleteClientByClientIDAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}