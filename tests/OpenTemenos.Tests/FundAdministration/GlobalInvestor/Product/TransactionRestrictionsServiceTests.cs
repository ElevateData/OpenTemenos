using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.TransactionRestrictions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class TransactionRestrictionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTransactionRestrictionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService
            .PostTransactionrestrictionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTransactionRestrictionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService
            .PostTransactionrestrictionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTransactionRestrictionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionRestrictionService
            .PutTransactionrestrictionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTransactionRestrictionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionRestrictionService
            .DeleteTransactionrestrictionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionRestrictionsByInternalIdAsync()
    {
        var result = _client.TransactionRestrictionService
            .GetTransactionrestrictionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTransactionRestrictionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService
            .PutTransactionrestrictionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTransactionRestrictionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService
            .DeleteTransactionrestrictionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}