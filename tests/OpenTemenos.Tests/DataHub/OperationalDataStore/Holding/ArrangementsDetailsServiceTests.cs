using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class ArrangementsDetailsServiceTests : CredentialManagement
{
    private const string CustomerId = "";
    private const string RecordId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetArrangementsForCustomersAsync()
    {
        var result = _client.ArrangementsDetailService
            .GetArrangementsForCustomersAsync(CustomerId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetArrangementAsync(RecordId, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementsForCustomerAsync()
    {
        var result = _client.ArrangementsDetailService
            .GetArrangementsForCustomerAsync(CustomerId, RecordId, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementsAsync()
    {
        var result = _client.ArrangementsDetailService.GetArrangementsAsync(RecordId, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementActivitiesAsync()
    {
        var result = _client.ArrangementsDetailService.GetArrangementActivitiesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingArrangementActivityAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingArrangementActivityAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingBundleArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingBundleArrangementAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingDepositArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingDepositArrangementAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingLoanArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingLoanArrangementAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetPendingConsentArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingConsentArrangementAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}