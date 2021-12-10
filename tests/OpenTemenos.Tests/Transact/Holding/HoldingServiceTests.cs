using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass, TestCategory("Transact")]
public class HoldingServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetHoldingsAsync()
    {
        var result = _client.HoldingService.GetHoldingsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerHoldingsAsync()
    {
        var result = _client.HoldingService.GetCustomerHoldingsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}