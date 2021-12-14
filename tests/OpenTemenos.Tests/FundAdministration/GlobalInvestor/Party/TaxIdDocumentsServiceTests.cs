using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.TaxIdDocuments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class TaxIdDocumentServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTaxIdDocumentsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TaxResidenceDocumentService
            .PostTaxIdDocumentsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTaxIdDocumentsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TaxResidenceDocumentService.PostTaxIdDocumentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTaxIdDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TaxResidenceDocumentService.PutTaxIdDocumentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTaxIdDocumentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TaxResidenceDocumentService
            .DeleteTaxIdDocumentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTaxIdDocumentsByInternalIdAsync()
    {
        var result = _client.TaxResidenceDocumentService
            .GetTaxIdDocumentsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTaxIdDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TaxResidenceDocumentService
            .PutTaxIdDocumentsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTaxIdDocumentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TaxResidenceDocumentService
            .DeleteTaxIdDocumentsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}