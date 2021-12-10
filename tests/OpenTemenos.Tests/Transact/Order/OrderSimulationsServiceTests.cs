using Transact;
using Transact.Order.OrderSimulations;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass, TestCategory("Transact")]
public class OrderSimulationServiceTests : CredentialManagement
{
    private const string OrderSimulationId = "1";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSecurityOrderSimulationAsync()
    {
        var result = _client.SecurityOrderSimulationService.GetSecurityOrderSimulationAsync(OrderSimulationId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecurityOrderSimulationAsync()
    {
        var orderSimulationId = string.Empty;
        var payload = new SecurityOrderSimulation();
        var result = _client.SecurityOrderSimulationService
            .CreateSecurityOrderSimulationAsync(orderSimulationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}