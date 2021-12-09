using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TaFunds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class TaFundsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string FundId = "1";

    [TestMethod]
    public void GetTaFundAsync()
    {
        var result = _client.TransferAgentFundService.GetTAfundAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostTaFundAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundService.PostTAfundAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutTaFundAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundService.PutTAfundAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteTaFundAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundService.DeleteTAfundAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTaFundByFundIdAsync()
    {
        var result = _client.TransferAgentFundService.GetTAfundByFundIdAsync(null, null, null, null, null, null, null, null, null, null, FundId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutTaFundByFundIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundService.PutTAfundByFundIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteTaFundByFundIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundService.DeleteTAfundByFundIDAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}