using Payment.PaymentOrders;

namespace OpenTemenos.Tests.Payments;

[TestClass]
public class PaymentOrdersServiceTests : CredentialManagement
{
    private const string PaymentOrderId = "1";
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPaymentOrdersAsync()
    {
        var result = _client.PaymentOrderService.GetPaymentOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePaymentOrderAsync()
    {
        var payload = new PaymentOrder();
        var result = _client.PaymentOrderService.CreatePaymentOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateInstantPaymentOrderAsync()
    {
        var payload = new InstantPaymentOrder();
        var result = _client.PaymentOrderService.CreateInstantPaymentOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void CancelExternalPaymentOrderAsync()
    {
        var paymentOrderId = string.Empty;
        var payload = new ExternalPaymentOrder();
        var result = _client.PaymentOrderService.CancelExternalPaymentOrderAsync(paymentOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApprovePaymentOrderAsync()
    {
        var paymentOrderId = string.Empty;
        var payload = new PaymentOrder();
        var result = _client.PaymentOrderService.ApprovePaymentOrderAsync(paymentOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentOrderAsync()
    {
        var result = _client.PaymentOrderService.GetPaymentOrderAsync(PaymentOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePaymentOrderAsync()
    {
        var paymentOrderId = string.Empty;
        var payload = new PaymentOrder();
        var result = _client.PaymentOrderService.UpdatePaymentOrderAsync(paymentOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePaymentOrderAsync()
    {
        var paymentOrderId = string.Empty;
        var payload = new PaymentOrderDelete();
        var result = _client.PaymentOrderService.DeletePaymentOrderAsync(paymentOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetTrackedPaymentOrdersAsync()
    {
        var result = _client.PaymentOrderService.GetTrackedPaymentOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGpiPaymentTrackingAsync()
    {
        var result = _client.PaymentOrderService.GetGpiPaymentTrackingAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentOrdersForRecallAsync()
    {
        var result = _client.PaymentOrderService.GetPaymentOrdersForRecallAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentOrderRecallStatusAsync()
    {
        var result = _client.PaymentOrderService.GetPaymentOrderRecallStatusAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateGPIPaymentStatusAsync()
    {
        var paymentId = string.Empty;
        var payload = new GPIPaymentStatus();
        var result = _client.PaymentOrderService.CreateGPIPaymentStatusAsync(paymentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateGPIPaymentStatusAsync()
    {
        var paymentId = string.Empty;
        var payload = new GPIPaymentStatus();
        var result = _client.PaymentOrderService.UpdateGPIPaymentStatusAsync(paymentId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}