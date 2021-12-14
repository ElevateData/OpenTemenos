using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Agents;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class AgentServiceTests : CredentialManagement
{
    private const string AgentId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAgentAsync()
    {
        var result = _client.DistributorService
            .GetAgentAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine(
            $@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body.Records!.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorService.PostAgentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorService.PutAgentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorService.DeleteAgentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentByAgentIdAsync()
    {
        var result = _client.DistributorService
            .GetAgentByagentIdAsync(AgentId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentByInternalIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorService
            .PutAgentByinternalIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentByInternalIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorService
            .DeleteAgentByinternalIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}