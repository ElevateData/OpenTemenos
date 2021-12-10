using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundPromoters;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundPromotersServiceTests : CredentialManagement
{
    private const string NPromoter = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetFundPromoterAsync()
    {
        var result = _client.FundPromoterService
            .GetFundpromoterAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundPromoterAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundPromoterService.PostFundpromoterAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundPromoterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundPromoterService.PutFundpromoterAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundPromoterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundPromoterService.DeleteFundpromoterAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundPromoterByFPIdAsync()
    {
        var result = _client.FundPromoterService
            .GetFundpromoterByFPIdAsync(null, null, null, null, null, null, null, null, null, null, NPromoter).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundPromoterByFPIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundPromoterService
            .PutFundpromoterByFPIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundPromoterByFPIDAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundPromoterService
            .DeleteFundpromoterByFPIDAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}