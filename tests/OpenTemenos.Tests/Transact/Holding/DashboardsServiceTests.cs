using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class DashboardsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetLimitsAsync()
    {
        var result = _client.CorporateDashboardService
            .GetLimitsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDashboardDraftsAsync()
    {
        var result = _client.CorporateDashboardService
            .GetDashboardDraftsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBankMessagesAsync()
    {
        var result = _client.CorporateDashboardService
            .GetBankMessagesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDashboardApprovalsAsync()
    {
        var result = _client.CorporateDashboardService
            .GetDashboardApprovalsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}