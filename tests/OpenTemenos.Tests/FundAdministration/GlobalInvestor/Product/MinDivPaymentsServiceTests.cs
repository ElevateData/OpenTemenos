using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.MinDivPayments;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class MinDivPaymentsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostMinDivPaymentsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService.PostMindivpaymentsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostMinDivPaymentsAsync()
    {
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService.PostMindivpaymentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutMinDivPaymentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.MinDivPaymentService.PutMindivpaymentsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteMinDivPaymentsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.MinDivPaymentService.DeleteMindivpaymentsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetMinDivPaymentsByInternalIdAsync()
    {
        var result = _client.MinDivPaymentService
            .GetMindivpaymentsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutMinDivPaymentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService
            .PutMindivpaymentsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteMinDivPaymentsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.MinDivPaymentService
            .DeleteMindivpaymentsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}