using System.Diagnostics;
using System.Linq;
using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalInvestor.Party.Agents;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AgentsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string AgentId = "1";
    private const string InternalId = "1";

    [TestMethod]
    public void GetAgentAsync()
    {
        var result = _client.DistributorService.GetAgentAsync(null, null, null, null, null, null,null,null,null,null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"InternalId: {result.Body.Records?.First().InternalId}");
        Debug.WriteLine($@"MainAgentId: {result.Body.Records?.First().MainAgentId}");
    }

    [TestMethod, Ignore("POST method")]
    public void PostAgentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorService.PostAgentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutAgentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorService.PutAgentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteAgentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorService.DeleteAgentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentByAgentIdAsync()
    {
        var result = _client.DistributorService.GetAgentByagentIdAsync(null, null, null, null, null, null,null,null,null,null, AgentId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutAgentByInternalIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorService.PutAgentByinternalIdAsync(null, null, null, null, null, InternalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteAgentByInternalIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorService.DeleteAgentByinternalIdAsync(null, null, null, null, null, InternalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}