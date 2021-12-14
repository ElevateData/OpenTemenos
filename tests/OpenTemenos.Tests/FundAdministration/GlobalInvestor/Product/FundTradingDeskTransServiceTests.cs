using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundTradingDeskTrans;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class FundTradingDeskTranServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundTradingDeskTransByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService
            .PostFundtradingdesktransByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundTradingDeskTransAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService.PostFundtradingdesktransAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundTradingDeskTransAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundTradingDeskService.PutFundtradingdesktransAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundTradingDeskTransAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundTradingDeskService
            .DeleteFundtradingdesktransAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundTradingDeskTransByInternalIdAsync()
    {
        var result = _client.FundTradingDeskService
            .GetFundtradingdesktransByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundTradingDeskTransByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService
            .PutFundtradingdesktransByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundTradingDeskTransByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService
            .DeleteFundtradingdesktransByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}