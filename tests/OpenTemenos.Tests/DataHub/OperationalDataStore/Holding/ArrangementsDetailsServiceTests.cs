using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class ArrangementsDetailServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private const string RecordId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetArrangementsForCustomersAsync()
    {
        var result = _client.ArrangementsDetailService
            .GetArrangementsForCustomersAsync(CustomerId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetArrangementAsync(RecordId)
            .Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementsForCustomerAsync()
    {
        var result = _client.ArrangementsDetailService
            .GetArrangementsForCustomerAsync(CustomerId, RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetArrangementsAsync()
    {
        var result = _client.ArrangementsDetailService.GetArrangementsAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetArrangementActivitiesAsync()
    {
        var result = _client.ArrangementsDetailService.GetArrangementActivitiesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetPendingArrangementActivityAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingArrangementActivityAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetPendingBundleArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingBundleArrangementAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetPendingDepositArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingDepositArrangementAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetPendingLoanArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingLoanArrangementAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetPendingConsentArrangementAsync()
    {
        var result = _client.ArrangementsDetailService.GetPendingConsentArrangementAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}