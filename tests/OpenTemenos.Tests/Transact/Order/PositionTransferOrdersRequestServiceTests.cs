using Transact;
using Transact.Order.PositionTransferOrdersRequests;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class PositionTransferOrdersRequestServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityPositionTransferOrdersInitiationAsync()
    {
        var payload = new SecurityPositionTransferOrdersInitiation();
        var result = _client.SecurityPositionTransferService
            .CreateSecurityPositionTransferOrdersInitiationAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSecurityPositionTransferOrdersInitiationAsync()
    {
        var positionTransferOrderId = string.Empty;
        var payload = new SecurityPositionTransferOrdersInitiation();
        var result = _client.SecurityPositionTransferService
            .UpdateSecurityPositionTransferOrdersInitiationAsync(positionTransferOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityPositionTransferOrdersInitiationAsync()
    {
        var positionTransferOrderId = string.Empty;
        var payload = new SecurityPositionTransferOrdersInitiationDelete();
        var result = _client.SecurityPositionTransferService
            .DeleteSecurityPositionTransferOrdersInitiationAsync(positionTransferOrderId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApprovePositionTransferRequestAsync()
    {
        var positionTransferOrderId = string.Empty;
        var result = _client.SecurityPositionTransferService
            .ApprovePositionTransferRequestAsync(positionTransferOrderId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}