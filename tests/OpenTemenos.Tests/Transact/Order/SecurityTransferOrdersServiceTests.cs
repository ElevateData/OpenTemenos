using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Order.SecurityTransferOrders;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
[TestCategory("Transact")]
public class SecurityTransferOrderServiceTests : CredentialManagement
{
    private const string SecurityTransferOrderId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetInboundSecurityTransferOrdersAsync()
    {
        var result = _client.SecurityTransferService.GetInboundSecurityTransferOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutboundSecurityTransferOrdersAsync()
    {
        var result = _client.SecurityTransferService.GetOutboundSecurityTransferOrdersAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityTransferOrderAsync()
    {
        var payload = new SecurityTransferOrder();
        var result = _client.SecurityTransferService.CreateSecurityTransferOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSecurityTransferOrdersAsync()
    {
        var result = _client.SecurityTransferService.GetSecurityTransferOrdersAsync(SecurityTransferOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSecurityTransferOrderAsync()
    {
        var securityTransferOrderId = string.Empty;
        var payload = new SecurityTransferOrder();
        var result = _client.SecurityTransferService.UpdateSecurityTransferOrderAsync(securityTransferOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityTransferDraftOrderAsync()
    {
        var payload = new SecurityTransferOrder();
        var result = _client.SecurityTransferService.CreateSecurityTransferDraftOrderAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityTransferRequestAsync()
    {
        var payload = new SecurityTransferRequest();
        var result = _client.SecurityTransferService.CreateSecurityTransferRequestAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}