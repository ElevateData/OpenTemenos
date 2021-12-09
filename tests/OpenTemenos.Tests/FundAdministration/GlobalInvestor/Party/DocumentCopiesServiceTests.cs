using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.DocumentCopies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class DocumentCopiesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostDocumentCopiesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DocumentCopyService.PostDocumentcopiesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostDocumentCopiesAsync()
    {
        var payload = new _0Payload();
        var result = _client.DocumentCopyService.PostDocumentcopiesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutDocumentCopiesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DocumentCopyService.PutDocumentcopiesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteDocumentCopiesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DocumentCopyService.DeleteDocumentcopiesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetDocumentCopiesByInternalIdAsync()
    {
        var result = _client.DocumentCopyService.GetDocumentcopiesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutDocumentCopiesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DocumentCopyService.PutDocumentcopiesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteDocumentCopiesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DocumentCopyService.DeleteDocumentcopiesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}