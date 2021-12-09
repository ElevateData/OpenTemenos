using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FxDetails;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FxDetailsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string Nptf = "1";

    [TestMethod, Ignore("POST method")]
    public void PostFxDetailsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ForexService.PostFxdetailsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostFxDetailsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ForexService.PostFxdetailsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFxDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForexService.PutFxdetailsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFxDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForexService.DeleteFxdetailsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFxDetailsByNptfAsync()
    {
        var result = _client.ForexService.GetFxdetailsBynptfAsync(null, null, null, null, null, null, null, null, null, null, Nptf).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutFxDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ForexService.PutFxdetailsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteFxDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ForexService.DeleteFxdetailsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}