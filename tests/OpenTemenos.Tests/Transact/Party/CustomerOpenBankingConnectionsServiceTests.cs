using Transact;
using Transact.Party.CustomerOpenBankingConnections;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerOpenBankingConnectionsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateOpenBankingConnectionAsync()
    {
        var connectionId = string.Empty;
        var payload = new OpenBankingConnection();
        var result = _client.CustomerOpenBankingConnectionsService
            .CreateOpenBankingConnectionAsync(connectionId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void RemoveOpenBankingConnectionAsync()
    {
        var connectionId = string.Empty;
        var payload = new OpenBankingConnection1();
        var result = _client.CustomerOpenBankingConnectionsService
            .RemoveOpenBankingConnectionAsync(connectionId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ReconnectOpenBankingConnectionAsync()
    {
        var connectionId = string.Empty;
        var payload = new OpenBankingConnection();
        var result = _client.CustomerOpenBankingConnectionsService
            .ReconnectOpenBankingConnectionAsync(connectionId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void RefreshOpenBankingConnectionAsync()
    {
        var connectionId = string.Empty;
        var payload = new OpenBankingConnection2();
        var result = _client.CustomerOpenBankingConnectionsService
            .RefreshOpenBankingConnectionAsync(connectionId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetThirdPartyProviderConsentsAsync()
    {
        var result = _client.CustomerOpenBankingConnectionsService.GetThirdPartyProviderConsentsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}