using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.UsTaxOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class UsTaxOptionsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostUsTaxOptionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService.PostUstaxoptionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostUsTaxOptionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService.PostUstaxoptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutUsTaxOptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.UsTaxOptionService.PutUstaxoptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteUsTaxOptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.UsTaxOptionService.DeleteUstaxoptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetUsTaxOptionsByInternalIdAsync()
    {
        var result = _client.UsTaxOptionService.GetUstaxoptionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutUsTaxOptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService.PutUstaxoptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteUsTaxOptionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.UsTaxOptionService.DeleteUstaxoptionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}