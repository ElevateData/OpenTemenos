using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class ReportsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetProfitabilityReportAsync()
    {
        var result = _client.ReportService.GetProfitabilityReportAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCurrencyCalendarPositionsReportAsync()
    {
        var result = _client.ReportService.GetCurrencyCalendarPositionsReportAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetBlotterReportAsync()
    {
        var result = _client.ReportService.GetBlotterReportAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetMoneyMarketEventsToDateAsync()
    {
        var result = _client.ReportService.GetMoneyMarketEventsToDateAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutstandingForexDealsTodayAsync()
    {
        var result = _client.ReportService.GetOutstandingForexDealsTodayAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}