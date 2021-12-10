using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class PaymentDetailServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetPaymentOrderPurposeCodesAsync()
    {
        var result = _client.PaymentService.GetPaymentOrderPurposeCodesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPaymentOrderProductDetailsAsync()
    {
        var result = _client.PaymentService.GetPaymentOrderProductDetailsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPaymentOrderCountryRulesAsync()
    {
        var result = _client.PaymentService.GetPaymentOrderCountryRulesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingPaymentsAsync()
    {
        var result = _client.PaymentService
            .GetPendingPaymentsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPaymentFeesAndChargesAsync()
    {
        var result = _client.PaymentService.GetPaymentFeesAndChargesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetUploadFileTypesAsync()
    {
        var result = _client.PaymentService.GetUploadFileTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}