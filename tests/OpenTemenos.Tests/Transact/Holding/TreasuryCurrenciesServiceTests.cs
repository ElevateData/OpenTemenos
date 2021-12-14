using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[TestCategory("Transact")]
public class TreasuryCurrencyServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCurrencyMarketRatesAsync()
    {
        var result = _client.TreasuryCurrencyService.GetCurrencyMarketRatesAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyRevaluationRatesAsync()
    {
        var result = _client.TreasuryCurrencyService.GetCurrencyRevaluationRatesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}