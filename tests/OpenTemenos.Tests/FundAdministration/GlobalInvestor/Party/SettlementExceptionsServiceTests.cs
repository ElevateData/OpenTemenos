using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.SettlementExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class SettlementExceptionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSettlementExceptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SettlementExceptionService
            .PostSettlementexceptionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSettlementExceptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.SettlementExceptionService
            .PostSettlementexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSettlementExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SettlementExceptionService
            .PutSettlementexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSettlementExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SettlementExceptionService
            .DeleteSettlementexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSettlementExceptionsByInternalIdAsync()
    {
        var result = _client.SettlementExceptionService
            .GetSettlementexceptionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSettlementExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SettlementExceptionService
            .PutSettlementexceptionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSettlementExceptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SettlementExceptionService
            .DeleteSettlementexceptionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}