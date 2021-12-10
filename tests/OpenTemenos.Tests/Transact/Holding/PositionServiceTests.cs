using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass, TestCategory("Transact")]
public class PositionServiceTests : CredentialManagement
{
    private const string CurrencyId = "USD";
    private const string TransactionId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetTreasuryCashPositionAsync()
    {
        var result = _client.PositionService.GetTreasuryCashPositionAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetTreasuryGapPositionAsync()
    {
        var result = _client.PositionService.GetTreasuryGapPositionAsync(CurrencyId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetForexRevaluationPositionsAsync()
    {
        var result = _client.PositionService.GetForexRevaluationPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetTreasuryTransactionDetailsAsync()
    {
        var result = _client.PositionService.GetTreasuryTransactionDetailsAsync(TransactionId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}