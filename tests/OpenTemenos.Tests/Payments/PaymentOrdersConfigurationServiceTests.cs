namespace OpenTemenos.Tests.Payments;

[TestClass, TestCategory("Payments")]
public class PaymentOrdersConfigurationServiceTests : CredentialManagement
{
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPaymentOrderPurposesAsync()
    {
        var result = _client.PaymentOrderConfigurationService.GetPaymentOrderPurposesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentOrderProductsAsync()
    {
        var result = _client.PaymentOrderConfigurationService.GetPaymentOrderProductsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentOrderCountryRulesAsync()
    {
        var result = _client.PaymentOrderConfigurationService.GetPaymentOrderCountryRulesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetISOClearingCodesAsync()
    {
        var result = _client.PaymentOrderConfigurationService.GetISOClearingCodesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}