using Transact;
using Transact.Order.FiduciaryOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class FiduciaryOrderServiceTests : CredentialManagement
{
    private const string FiduciaryOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateFiduciaryOrderInitiationAsync()
    {
        var payload = new FiduciaryOrderInitiation();
        var result = _client.FiduciaryOrderService.CreateFiduciaryOrderInitiationAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetFiduciaryOrderInitiationAsync()
    {
        var result = _client.FiduciaryOrderService.GetFiduciaryOrderInitiationAsync(FiduciaryOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFiduciaryOrderInitiationAsync()
    {
        var fiduciaryOrderId = string.Empty;
        var payload = new FiduciaryOrderInitiation();
        var result = _client.FiduciaryOrderService.UpdateFiduciaryOrderInitiationAsync(fiduciaryOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFiduciaryOrderMaturityAsync()
    {
        var fiduciaryOrderId = string.Empty;
        var payload = new FiduciaryOrderMaturity();
        var result = _client.FiduciaryOrderService.UpdateFiduciaryOrderMaturityAsync(fiduciaryOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}