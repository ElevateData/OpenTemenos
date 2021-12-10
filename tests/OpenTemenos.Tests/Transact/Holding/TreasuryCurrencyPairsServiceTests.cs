using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class TreasuryCurrencyPairsServiceTests : CredentialManagement
{
    private const string CurrencyPair = "GBPUSD";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCurrencyPairPositionsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairPositionsAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyPairCalendarPositionsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairCalendarPositionsAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyPairMarketRatesAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairMarketRatesAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAllCurrencyPairPositionsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetAllCurrencyPairPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyPairPositionDealsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairPositionDealsAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyPairsAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyPairAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetCurrencyPairAsync(CurrencyPair)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetFxPortfolioValuationRatesAsync()
    {
        var result = _client.TreasuryCurrencyPairService.GetFxPortfolioValuationRatesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}