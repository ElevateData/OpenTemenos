using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaCrsDocuments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class FatcaCrsDocumentsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostFatcaCrsDocumentsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService.PostFatcaCrsDocumentsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostFatcaCrsDocumentsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService.PostFatcaCrsDocumentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFatcaCrsDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.DocumentService.PutFatcaCrsDocumentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFatcaCrsDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FatcaCrs.DocumentService.DeleteFatcaCrsDocumentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFatcaCrsDocumentsByInternalIdAsync()
    {
        var result = _client.FatcaCrs.DocumentService.GetFatcaCrsDocumentsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFatcaCrsDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService.PutFatcaCrsDocumentsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFatcaCrsDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FatcaCrs.DocumentService.DeleteFatcaCrsDocumentsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}