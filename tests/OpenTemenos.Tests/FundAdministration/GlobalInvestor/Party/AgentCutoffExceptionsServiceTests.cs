using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AgentCutoffExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class AgentCutoffExceptionServiceTests : CredentialManagement
{
    private const string InternalId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentCutoffExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService
            .PostAgentcutoffexceptionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentCutoffExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService
            .PostAgentcutoffexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentCutoffExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionCutoffForDistributorService
            .PutAgentcutoffexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentCutoffExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionCutoffForDistributorService
            .DeleteAgentcutoffexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentCutoffExceptionsByInternalIdAsync()
    {
        var result = _client.ExceptionCutoffForDistributorService
            .GetAgentcutoffexceptionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentCutoffExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService
            .PutAgentcutoffexceptionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentCutoffExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionCutoffForDistributorService
            .DeleteAgentcutoffexceptionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}