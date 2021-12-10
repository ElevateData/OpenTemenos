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
            .GetLimitsAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDashboardDraftsAsync()
    {
        var result = _client.CorporateDashboardService
            .GetDashboardDraftsAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBankMessagesAsync()
    {
        var result = _client.CorporateDashboardService
            .GetBankMessagesAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDashboardApprovalsAsync()
    {
        var result = _client.CorporateDashboardService
            .GetDashboardApprovalsAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}