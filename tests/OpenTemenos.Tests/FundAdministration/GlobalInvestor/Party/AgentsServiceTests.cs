using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Agents;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AgentsServiceTests : CredentialManagement
{
    private const string AgentId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAgentAsync()
    {
        var result = _client.DistributorService
            .GetAgentAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.Records!.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorService.PostAgentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorService.PutAgentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorService.DeleteAgentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentByAgentIdAsync()
    {
        var result = _client.DistributorService
            .GetAgentByagentIdAsync(null, null, null, null, null, null, null, null, null, null, AgentId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentByInternalIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorService
            .PutAgentByinternalIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentByInternalIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorService
            .DeleteAgentByinternalIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}