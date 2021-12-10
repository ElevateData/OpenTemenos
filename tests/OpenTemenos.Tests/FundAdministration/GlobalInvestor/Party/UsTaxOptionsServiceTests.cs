using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.UsTaxOptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class UsTaxOptionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostUsTaxOptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService.PostUstaxoptionsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostUsTaxOptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService.PostUstaxoptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutUsTaxOptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.UsTaxOptionService.PutUstaxoptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteUsTaxOptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.UsTaxOptionService.DeleteUstaxoptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetUsTaxOptionsByInternalIdAsync()
    {
        var result = _client.UsTaxOptionService
            .GetUstaxoptionsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutUsTaxOptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService
            .PutUstaxoptionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteUsTaxOptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService
            .DeleteUstaxoptionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}