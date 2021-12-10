using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FatcaCrsDocumentServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsDocumentsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService
            .PostFatcaCrsDocumentsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFatcaCrsDocumentsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService.PostFatcaCrsDocumentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.DocumentService.PutFatcaCrsDocumentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.DocumentService
            .DeleteFatcaCrsDocumentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFatcaCrsDocumentsByInternalIdAsync()
    {
        var result = _client.FatcaCrs.DocumentService
            .GetFatcaCrsDocumentsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFatcaCrsDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService
            .PutFatcaCrsDocumentsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFatcaCrsDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService
            .DeleteFatcaCrsDocumentsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}