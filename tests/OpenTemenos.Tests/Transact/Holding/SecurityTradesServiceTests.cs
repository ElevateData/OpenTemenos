using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass, TestCategory("Transact")]
public class SecurityTradeServiceTests : CredentialManagement
{
    private const string SecurityTradeId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSecurityTradesAsync()
    {
        var result = _client.SecurityTradeService.GetSecurityTradesAsync(SecurityTradeId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}