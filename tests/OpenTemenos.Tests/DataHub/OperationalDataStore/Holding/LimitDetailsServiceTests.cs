using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class LimitDetailServiceTests : CredentialManagement
{
    private const string MasterGroupKey = "";
    private const string RecordId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetExpiringLimitsAsync()
    {
        var result = _client.LimitDetailService.GetExpiringLimitsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetLimitsToReviewAsync()
    {
        var result = _client.LimitDetailService.GetLimitsToReviewAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLimitGroupAllocationsAsync()
    {
        var result = _client.LimitDetailService.GetLimitGroupAllocationsAsync(MasterGroupKey).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerLimitSharingPrioritiesAsync()
    {
        var result = _client.LimitDetailService.GetCustomerLimitSharingPrioritiesAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetCustomerLimitMasterGroupsAsync()
    {
        var result = _client.LimitDetailService.GetCustomerLimitMasterGroupsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [TestCategory("Parameter-less Method")]
    public void GetLimitSharingGroupAsync()
    {
        var result = _client.LimitDetailService.GetLimitSharingGroupAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}