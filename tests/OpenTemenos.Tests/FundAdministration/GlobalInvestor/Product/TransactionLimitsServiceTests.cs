using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TransactionLimits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class TransactionLimitsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostTransactionLimitsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionLimitService.PostTransactionLimitsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostTransactionLimitsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionLimitService.PostTransactionLimitsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutTransactionLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionLimitService.PutTransactionLimitsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteTransactionLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionLimitService.DeleteTransactionLimitsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionLimitsByInternalIdAsync()
    {
        var result = _client.TransactionLimitService.GetTransactionLimitsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutTransactionLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionLimitService.PutTransactionLimitsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteTransactionLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionLimitService.DeleteTransactionLimitsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}