using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AgentVdExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AgentVdExceptionsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentVdExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PostAgentVdExceptionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentVdExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService.PostAgentVdExceptionsAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentVdExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService.PutAgentVdExceptionsAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentVdExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService
            .DeleteAgentVdExceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentVdExceptionsByInternalIdAsync()
    {
        var result = _client.ExceptionValueDateService
            .GetAgentVdExceptionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentVdExceptionsByIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PutAgentVdExceptionsByIdAsync(null, null, null, null, null, InternalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentVdExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .DeleteAgentVdExceptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundVdExceptionsByParentProdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PostFundVdExceptionsByParentProdAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundVdExceptionsProdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PostFundVdExceptionsProdAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundVdExceptionsProdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService
            .PutFundVdExceptionsProdAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundVdExceptionsProdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService
            .DeleteFundVdExceptionsProdAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundVdExceptionsByInternalIdProdAsync()
    {
        var result = _client.ExceptionValueDateService
            .GetFundVdExceptionsByInternalIdProdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundVdExceptionsByIdProdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PutFundVdExceptionsByIdProdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundVdExceptionsByIdProdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .DeleteFundVdExceptionsByIdProdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}