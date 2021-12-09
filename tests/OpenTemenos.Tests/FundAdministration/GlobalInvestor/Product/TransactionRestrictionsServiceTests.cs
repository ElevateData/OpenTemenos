using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TransactionRestrictions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class TransactionRestrictionsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostTransactionRestrictionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService.PostTransactionrestrictionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostTransactionRestrictionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService.PostTransactionrestrictionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutTransactionRestrictionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionRestrictionService.PutTransactionrestrictionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteTransactionRestrictionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransactionRestrictionService.DeleteTransactionrestrictionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionRestrictionsByInternalIdAsync()
    {
        var result = _client.TransactionRestrictionService.GetTransactionrestrictionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutTransactionRestrictionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService.PutTransactionrestrictionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteTransactionRestrictionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransactionRestrictionService.DeleteTransactionrestrictionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}