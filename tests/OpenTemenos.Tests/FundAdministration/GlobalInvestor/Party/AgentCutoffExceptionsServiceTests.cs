using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAdministration.GlobalInvestor.Party.AgentCutoffExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AgentCutoffExceptionsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "";

    [TestMethod, Ignore("POST method")]
    public void PostAgentCutoffExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService.PostAgentcutoffexceptionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostAgentCutoffExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService.PostAgentcutoffexceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutAgentCutoffExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionCutoffForDistributorService.PutAgentcutoffexceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteAgentCutoffExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionCutoffForDistributorService.DeleteAgentcutoffexceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentCutoffExceptionsByInternalIdAsync()
    {
        var result = _client.ExceptionCutoffForDistributorService.GetAgentcutoffexceptionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutAgentCutoffExceptionsByIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService.PutAgentcutoffexceptionsByIdAsync(null, null, null, null, null,InternalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteAgentCutoffExceptionsByIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService.DeleteAgentcutoffexceptionsByIdAsync(null, null, null, null, null, InternalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}