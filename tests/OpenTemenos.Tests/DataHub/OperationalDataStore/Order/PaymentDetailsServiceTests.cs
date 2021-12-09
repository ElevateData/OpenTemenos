using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class PaymentDetailsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod]
    public void GetPaymentOrderPurposeCodesAsync()
    {
        var result = _client.PaymentService.GetPaymentOrderPurposeCodesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPaymentOrderProductDetailsAsync()
    {
        var result = _client.PaymentService.GetPaymentOrderProductDetailsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPaymentOrderCountryRulesAsync()
    {
        var result = _client.PaymentService.GetPaymentOrderCountryRulesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingPaymentsAsync()
    {
        var result = _client.PaymentService
            .GetPendingPaymentsAsync(null, null, null, null, null, null, null, null, null, null, null).Result;
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
        var result = _client.PaymentService.GetUploadFileTypesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}