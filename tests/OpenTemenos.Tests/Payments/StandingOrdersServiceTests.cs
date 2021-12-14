using OpenTemenos.Payments;
using OpenTemenos.Payments.StandingOrders;

namespace OpenTemenos.Tests.Payments;

[TestClass]
[TestCategory("Payments")]
public class StandingOrderServiceTests : CredentialManagement
{
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetOutwardErrorsAsync()
    {
        var result = _client.StandingOrderService.GetFailedTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetStandingOrdersAsync()
    {
        var result = _client.StandingOrderService.GetStandingOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateStandingOrderAsync()
    {
        var standingOrderId = string.Empty;
        var payload = new StandingOrder();
        var result = _client.StandingOrderService.CreateStandingOrderAsync(standingOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateStandingOrderAsync()
    {
        var standingOrderId = string.Empty;
        var payload = new StandingOrder();
        var result = _client.StandingOrderService.UpdateStandingOrderAsync(standingOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteStandingOrderAsync()
    {
        var standingOrderId = string.Empty;
        var payload = new StandingOrderDelete();
        var result = _client.StandingOrderService.DeleteStandingOrderAsync(standingOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApproveStandingOrderAsync()
    {
        var standingOrderId = string.Empty;
        var result = _client.StandingOrderService.ApproveStandingOrderAsync(standingOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void RejectStandingOrderAsync()
    {
        var standingOrderId = string.Empty;
        var payload = new StandingOrderDelete();
        var result = _client.StandingOrderService.RejectStandingOrderAsync(standingOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}