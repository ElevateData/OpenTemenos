using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class TreasuryCurrenciesServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCurrencyMarketRatesAsync()
    {
        var result = _client.TreasuryCurrencyService.GetCurrencyMarketRatesAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyRevaluationRatesAsync()
    {
        var result = _client.TreasuryCurrencyService.GetCurrencyRevaluationRatesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}