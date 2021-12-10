using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TransactionLimits;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class TransactionLimitsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTransactionLimitsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionLimitService
            .PostTransactionLimitsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTransactionLimitsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionLimitService.PostTransactionLimitsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTransactionLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionLimitService.PutTransactionLimitsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTransactionLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionLimitService.DeleteTransactionLimitsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionLimitsByInternalIdAsync()
    {
        var result = _client.TransactionLimitService
            .GetTransactionLimitsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTransactionLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionLimitService
            .PutTransactionLimitsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTransactionLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionLimitService
            .DeleteTransactionLimitsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}