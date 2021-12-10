using Transact;
using Transact.Order.SecurityOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class SecurityOrdersServiceTests : CredentialManagement
{
    private const string SecurityOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityOrderAsync()
    {
        var payload = new SecurityOrder();
        var result = _client.SecurityOrderService.CreateSecurityOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSecurityOrderAsync()
    {
        var result = _client.SecurityOrderService.GetSecurityOrderAsync(SecurityOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSecurityOrderAsync()
    {
        var securityOrderId = string.Empty;
        var payload = new SecurityOrder();
        var result = _client.SecurityOrderService.UpdateSecurityOrderAsync(securityOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPeriodicFeeEstimatesAsync()
    {
        var customerId = string.Empty;
        var portfolioId = string.Empty;
        var instrumentId = string.Empty;
        var tradeCurrency = string.Empty;
        var quantity = string.Empty;
        var amount = string.Empty;
        var result = _client.SecurityOrderService
            .GetPeriodicFeeEstimatesAsync(customerId, portfolioId, instrumentId, tradeCurrency, quantity, amount)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateStopPriceOrderAsync()
    {
        var payload = new SecurityOrder();
        var result = _client.SecurityOrderService.CreateStopPriceOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateStopPriceLimitOrderAsync()
    {
        var payload = new SecurityOrder();
        var result = _client.SecurityOrderService.CreateStopPriceLimitOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}