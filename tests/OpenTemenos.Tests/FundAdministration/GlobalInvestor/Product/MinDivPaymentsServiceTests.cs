using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class MinDivPaymentsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostMinDivPaymentsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService.PostMindivpaymentsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostMinDivPaymentsAsync()
    {
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService.PostMindivpaymentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutMinDivPaymentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.MinDivPaymentService.PutMindivpaymentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteMinDivPaymentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.MinDivPaymentService.DeleteMindivpaymentsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetMinDivPaymentsByInternalIdAsync()
    {
        var result = _client.MinDivPaymentService.GetMindivpaymentsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutMinDivPaymentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService.PutMindivpaymentsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteMinDivPaymentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService.DeleteMindivpaymentsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}