using Transact;
using Transact.Holding.PortfolioSettlements;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass, TestCategory("Transact")]
public class PortfolioSettlementServiceTests : CredentialManagement
{
    private const string PortfolioId = "1";
    private const string SecuritySettlementsId = "1";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetOverdueSettlementsByPortfolioAsync()
    {
        var result = _client.SecuritySettlementService.GetOverdueSettlementsByPortfolioAsync(PortfolioId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSecuritySettlementsAsync()
    {
        var result = _client.SecuritySettlementService.GetSecuritySettlementsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetFullSettlementsAsync()
    {
        var result = _client.SecuritySettlementService.GetFullSettlementsAsync(SecuritySettlementsId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFullSettlementsAsync()
    {
        var securitySettlementsId = string.Empty;
        var payload = new FullSettlements();
        var result = _client.SecuritySettlementService.UpdateFullSettlementsAsync(securitySettlementsId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPartialSettlementsAsync()
    {
        var result = _client.SecuritySettlementService.GetPartialSettlementsAsync(SecuritySettlementsId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePartialSettlementsAsync()
    {
        var securitySettlementsId = string.Empty;
        var payload = new PartialSettlements();
        var result = _client.SecuritySettlementService.UpdatePartialSettlementsAsync(securitySettlementsId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}