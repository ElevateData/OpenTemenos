using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.CommissionPaymentCurrencies;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class CommissionPaymentCurrencyServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommissionPaymentCurrencyByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PostCommissionPaymentCurrencyByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommissionPaymentCurrencyAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PostCommissionPaymentCurrencyAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommissionPaymentCurrencyAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PutCommissionPaymentCurrencyAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommissionPaymentCurrencyAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .DeleteCommissionPaymentCurrencyAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCommissionPaymentCurrencyByInternalIdAsync()
    {
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .GetCommissionPaymentCurrencyByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommissionPaymentCurrencyByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PutCommissionPaymentCurrencyByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommissionPaymentCurrencyByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .DeleteCommissionPaymentCurrencyByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}