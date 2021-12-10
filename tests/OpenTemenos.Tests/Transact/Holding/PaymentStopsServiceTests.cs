using Transact;
using Transact.Holding.PaymentStops;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class PaymentStopsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePaymentStopAsync()
    {
        var paymentStopId = string.Empty;
        var payload = new PaymentStop();
        var result = _client.PaymentStopService.CreatePaymentStopAsync(paymentStopId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePaymentStopAsync()
    {
        var paymentStopId = string.Empty;
        var payload = new PaymentStop();
        var result = _client.PaymentStopService.UpdatePaymentStopAsync(paymentStopId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentStopsAsync()
    {
        var result = _client.PaymentStopService.GetPaymentStopsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApprovePaymentStopAsync()
    {
        var paymentStopId = string.Empty;
        var payload = new PaymentStop();
        var result = _client.PaymentStopService.CreatePaymentStopAsync(paymentStopId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void RejectPaymentStopAsync()
    {
        var paymentStopId = string.Empty;
        var payload = new PaymentStopDelete();
        var result = _client.PaymentStopService.RejectPaymentStopAsync(paymentStopId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}