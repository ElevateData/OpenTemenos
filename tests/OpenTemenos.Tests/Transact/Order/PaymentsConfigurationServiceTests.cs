using System;
using Transact;
using Transact.Order.PaymentsConfiguration;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class PaymentsConfigurationServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateLocalClearingAsync()
    {
        var systemId = string.Empty;
        var payload = new LocalClearing();
        var result = _client.PaymentConfigurationService.UpdateLocalClearingAsync(systemId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method, Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void UpdatePaymentOrderParameterAsync()
    {
        var companyIdPath = string.Empty;
        var payload = new PaymentOrderParameter();
        var result = _client.PaymentConfigurationService.UpdatePaymentOrderParameterAsync(companyIdPath, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method, Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void UpdatePaymentOrderProductAsync()
    {
        var productId = string.Empty;
        var payload = new PaymentOrderProduct();
        var result = _client.PaymentConfigurationService.UpdatePaymentOrderProductAsync(productId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}