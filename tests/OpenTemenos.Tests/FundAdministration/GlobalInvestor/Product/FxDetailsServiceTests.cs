using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FxDetails;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class FxDetailServiceTests : CredentialManagement
{
    private const string Nptf = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFxDetailsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ForexService.PostFxdetailsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFxDetailsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ForexService.PostFxdetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFxDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForexService.PutFxdetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFxDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForexService.DeleteFxdetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFxDetailsByNptfAsync()
    {
        var result = _client.ForexService
            .GetFxdetailsBynptfAsync(Nptf).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFxDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ForexService.PutFxdetailsByIdAsync(internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFxDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ForexService.DeleteFxdetailsByIdAsync(internalId, payload: payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}