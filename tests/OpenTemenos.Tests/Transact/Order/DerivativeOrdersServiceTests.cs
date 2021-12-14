using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.DerivativeOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
[TestCategory("Transact")]
public class DerivativeOrderServiceTests : CredentialManagement
{
    private const string DerivativeOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetOTCDerivativeOrdersAsync()
    {
        var result = _client.DerivativeInstrumentOrderService.GetOTCDerivativeOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetETDDerivativeOrdersAsync()
    {
        var result = _client.DerivativeInstrumentOrderService.GetETDDerivativeOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateDerivativesOrderAsync()
    {
        var payload = new DerivativesOrder();
        var result = _client.DerivativeInstrumentOrderService.CreateDerivativesOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetDerivativesOrderAsync()
    {
        var result = _client.DerivativeInstrumentOrderService.GetDerivativesOrderAsync(DerivativeOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDerivativesOrderAsync()
    {
        var derivativeOrderId = string.Empty;
        var payload = new DerivativesOrder();
        var result = _client.DerivativeInstrumentOrderService.UpdateDerivativesOrderAsync(derivativeOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}