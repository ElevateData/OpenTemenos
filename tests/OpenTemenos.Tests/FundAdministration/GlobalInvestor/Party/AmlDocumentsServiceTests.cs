using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AmlDocuments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AmlDocumentsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlDocumentsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .PostamldocumentsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlDocumentsAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .PostamldocumentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .PutamldocumentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .DeleteamldocumentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAmlDocumentsByInternalIdAsync()
    {
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .GetamldocumentsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .PutamldocumentsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlDocumentsService
            .DeleteamldocumentsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}