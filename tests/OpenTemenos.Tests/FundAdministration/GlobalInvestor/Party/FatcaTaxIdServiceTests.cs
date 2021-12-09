using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.FatcaTaxId;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class FatcaTaxIdServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTaxIdByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TaxResidenceIdService.PosttaxidByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTaxIdAsync()
    {
        var payload = new _0Payload();
        var result = _client.TaxResidenceIdService.PosttaxidAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTaxIdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TaxResidenceIdService.PuttaxidAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTaxIdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TaxResidenceIdService.DeletetaxidAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTaxIdByInternalIdAsync()
    {
        var result = _client.TaxResidenceIdService
            .GettaxidByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTaxIdByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TaxResidenceIdService.PuttaxidByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTaxIdByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TaxResidenceIdService
            .DeletetaxidByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}