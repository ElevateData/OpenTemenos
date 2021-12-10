using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class SecurityPositionsServiceTests : CredentialManagement
{
    private const string InstrumentId = "1";
    private const string PortfolioId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPortfoliosTransactionsAsync()
    {
        var result = _client.SecurityPositionService.GetPortfoliosTransactionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSecurityInventoryPositionsAsync()
    {
        var result = _client.SecurityPositionService.GetSecurityInventoryPositionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPortfolioTransactionsAsync()
    {
        var result = _client.SecurityPositionService.GetPortfolioTransactionsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetInstrumentPositionsAsync()
    {
        var result = _client.SecurityPositionService.GetInstrumentPositionsAsync(InstrumentId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPortfolioSecurityPositionsAsync()
    {
        var result = _client.SecurityPositionService.GetPortfolioSecurityPositionsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSecurityMovementsByPortfolioAsync()
    {
        var result = _client.SecurityPositionService.GetPortfoliosTransactionsAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}