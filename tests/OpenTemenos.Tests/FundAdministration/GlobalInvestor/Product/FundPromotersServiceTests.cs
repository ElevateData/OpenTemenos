using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundPromoters;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FundPromoterServiceTests : CredentialManagement
{
    private const string NPromoter = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetFundPromoterAsync()
    {
        var result = _client.FundPromoterService
            .GetFundpromoterAsync().Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundPromoterAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundPromoterService.PostFundpromoterAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundPromoterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundPromoterService.PutFundpromoterAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundPromoterAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundPromoterService.DeleteFundpromoterAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundPromoterByFPIdAsync()
    {
        var result = _client.FundPromoterService
            .GetFundpromoterByFPIdAsync(NPromoter).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundPromoterByFPIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundPromoterService
            .PutFundpromoterByFPIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundPromoterByFPIDAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundPromoterService
            .DeleteFundpromoterByFPIDAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}