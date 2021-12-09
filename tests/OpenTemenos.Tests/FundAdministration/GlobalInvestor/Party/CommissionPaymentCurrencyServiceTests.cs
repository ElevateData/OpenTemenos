using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.CommissionPaymentCurrency;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class CommissionPaymentCurrencyServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommissionPaymentCurrencyByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PostCommissionPaymentCurrencyByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommissionPaymentCurrencyAsync()
    {
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PostCommissionPaymentCurrencyAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommissionPaymentCurrencyAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .PutCommissionPaymentCurrencyAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommissionPaymentCurrencyAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .DeleteCommissionPaymentCurrencyAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCommissionPaymentCurrencyByInternalIdAsync()
    {
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .GetCommissionPaymentCurrencyByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
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
            .PutCommissionPaymentCurrencyByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommissionPaymentCurrencyByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.DistributorExceptionCommissionPaymentCurrencyService
            .DeleteCommissionPaymentCurrencyByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}