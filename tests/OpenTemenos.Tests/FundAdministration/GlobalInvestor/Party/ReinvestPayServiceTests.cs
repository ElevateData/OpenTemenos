using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ReinvestPay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ReinvestPayServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostReinvestPayByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService.PostReinvestpayByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostReinvestPayAsync()
    {
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService.PostReinvestpayAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutReinvestPayAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayService.PutReinvestpayAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteReinvestPayAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ReinvestOrPayService.DeleteReinvestpayAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetReinvestPayByInternalIdAsync()
    {
        var result = _client.ReinvestOrPayService.GetReinvestpayByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutReinvestPayByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService.PutReinvestpayByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteReinvestPayByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ReinvestOrPayService.DeleteReinvestpayByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}