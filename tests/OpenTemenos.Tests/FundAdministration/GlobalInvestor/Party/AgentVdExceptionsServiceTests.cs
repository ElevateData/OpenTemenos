using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AgentVdExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class AgentVdExceptionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentVdExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PostAgentVdExceptionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAgentVdExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService.PostAgentVdExceptionsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentVdExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService.PutAgentVdExceptionsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentVdExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService
            .DeleteAgentVdExceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAgentVdExceptionsByInternalIdAsync()
    {
        var result = _client.ExceptionValueDateService
            .GetAgentVdExceptionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAgentVdExceptionsByIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PutAgentVdExceptionsByIdAsync(InternalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAgentVdExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .DeleteAgentVdExceptionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundVdExceptionsByParentProdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PostFundVdExceptionsByParentProdAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundVdExceptionsProdAsync()
    {
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .PostFundVdExceptionsProdAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundVdExceptionsProdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService
            .PutFundVdExceptionsProdAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundVdExceptionsProdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExceptionValueDateService
            .DeleteFundVdExceptionsProdAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundVdExceptionsByInternalIdProdAsync()
    {
        var result = _client.ExceptionValueDateService
            .GetFundVdExceptionsByInternalIdProdAsync(
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
            .PutFundVdExceptionsByIdProdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundVdExceptionsByIdProdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ExceptionValueDateService
            .DeleteFundVdExceptionsByIdProdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}