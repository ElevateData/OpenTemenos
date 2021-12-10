using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CurrencyPositionServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCurrencyPositionsAsync()
    {
        var result = _client.CurrencyPositionService
            .GetCurrencyPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCurrencyCalendarPositionsAsync()
    {
        var result = _client.CurrencyPositionService
            .GetCurrencyCalendarPositionsAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}