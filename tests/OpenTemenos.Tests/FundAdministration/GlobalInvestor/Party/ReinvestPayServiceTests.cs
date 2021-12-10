using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ReinvestPay;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ReinvestPayServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostReinvestPayByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService.PostReinvestpayByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostReinvestPayAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService.PostReinvestpayAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutReinvestPayAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayService.PutReinvestpayAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteReinvestPayAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayService.DeleteReinvestpayAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetReinvestPayByInternalIdAsync()
    {
        var result = _client.ReinvestOrPayService
            .GetReinvestpayByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutReinvestPayByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService
            .PutReinvestpayByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteReinvestPayByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService
            .DeleteReinvestpayByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}