using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.DocumentCopies;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class DocumentCopiesServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostDocumentCopiesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DocumentCopyService.PostDocumentcopiesByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostDocumentCopiesAsync()
    {
        var payload = new _0Payload();
        var result = _client.DocumentCopyService.PostDocumentcopiesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutDocumentCopiesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DocumentCopyService.PutDocumentcopiesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteDocumentCopiesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DocumentCopyService.DeleteDocumentcopiesAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetDocumentCopiesByInternalIdAsync()
    {
        var result = _client.DocumentCopyService
            .GetDocumentcopiesByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutDocumentCopiesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DocumentCopyService
            .PutDocumentcopiesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteDocumentCopiesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DocumentCopyService
            .DeleteDocumentcopiesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}