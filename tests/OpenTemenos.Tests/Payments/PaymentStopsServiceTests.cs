using Payment.PaymentStops;

namespace OpenTemenos.Tests.Payments;

[TestClass]
public class PaymentStopsServiceTests : CredentialManagement
{
    private const string AccountId = "23701";
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPaymentStopAsync()
    {
        var result = _client.PaymentStopService.GetPaymentStopAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePaymentStopAsync()
    {
        var accountId = string.Empty;
        var payload = new PaymentStop();
        var result = _client.PaymentStopService.CreatePaymentStopAsync(accountId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePaymentStopAsync()
    {
        var accountId = string.Empty;
        var payload = new PaymentStop();
        var result = _client.PaymentStopService.UpdatePaymentStopAsync(accountId, payload)
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
}