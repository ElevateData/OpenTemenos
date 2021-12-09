using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Clients;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ClientsServiceTests : CredentialManagement
{
    private const string ClientId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    public void GetClientAsync()
    {
        var result = _client.InvestorService.GetClientAsync(null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostClientAsync()
    {
        var payload = new _0Payload();
        var result = _client.InvestorService.PostClientAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutClientAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorService.PutClientAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteClientAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.InvestorService.DeleteClientAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetClientByClientIdAsync()
    {
        var result = _client.InvestorService
            .GetClientByClientIdAsync(null, null, null, null, null, null, null, null, null, null, ClientId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutClientByInternalIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorService
            .PutClientByinternalIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteClientByClientIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.InvestorService
            .DeleteClientByClientIDAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}