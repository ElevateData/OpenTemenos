using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundTradingDeskTrans;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundTradingDeskTransServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundTradingDeskTransByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService
            .PostFundtradingdesktransByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundTradingDeskTransAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService.PostFundtradingdesktransAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundTradingDeskTransAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundTradingDeskService.PutFundtradingdesktransAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundTradingDeskTransAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundTradingDeskService
            .DeleteFundtradingdesktransAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundTradingDeskTransByInternalIdAsync()
    {
        var result = _client.FundTradingDeskService
            .GetFundtradingdesktransByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
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
            .PutFundtradingdesktransByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundTradingDeskTransByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundTradingDeskService
            .DeleteFundtradingdesktransByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}