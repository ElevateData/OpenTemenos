using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TaFunds;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class TaFundServiceTests : CredentialManagement
{
    private const string FundId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetTaFundAsync()
    {
        var result = _client.TransferAgentFundService
            .GetTAfundAsync().Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTaFundAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundService.PostTAfundAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTaFundAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundService.PutTAfundAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTaFundAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundService.DeleteTAfundAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTaFundByFundIdAsync()
    {
        var result = _client.TransferAgentFundService
            .GetTAfundByFundIdAsync(FundId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTaFundByFundIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundService
            .PutTAfundByFundIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTaFundByFundIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundService
            .DeleteTAfundByFundIDAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}