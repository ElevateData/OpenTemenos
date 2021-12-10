using Transact;
using Transact.Order.ForexCustomerOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class ForexCustomerOrderServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string LimitOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerForexLimitOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetCustomerForexLimitOrdersAsync(LimitOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateForexLimitOrderAsync()
    {
        var limitOrderId = string.Empty;
        var payload = new ForexLimitOrder();
        var result = _client.TreasuryForexOrderService.UpdateForexLimitOrderAsync(limitOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateForexLimitOrderAsync()
    {
        var payload = new ForexLimitOrder1();
        var result = _client.TreasuryForexOrderService.CreateForexLimitOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerForexDealsAsync()
    {
        var result = _client.TreasuryForexOrderService.GetCustomerForexDealsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetForexOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetForexOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateForexOrderAsync()
    {
        var payload = new ForexOrder();
        var result = _client.TreasuryForexOrderService.CreateForexOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutstandingForexOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetOutstandingForexOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}