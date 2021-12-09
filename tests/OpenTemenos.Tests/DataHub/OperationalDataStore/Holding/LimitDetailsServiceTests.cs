using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass]
public class LimitDetailsServiceTests : CredentialManagement
{
    private const string MasterGroupKey = "";
    private const string RecordId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);

    [TestMethod]
    public void GetExpiringLimitsAsync()
    {
        var result = _client.LimitDetailService.GetExpiringLimitsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLimitsToReviewAsync()
    {
        var result = _client.LimitDetailService.GetLimitsToReviewAsync(null, null, null).Result;
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
    public void GetCustomerLimitMasterGroupsAsync()
    {
        var result = _client.LimitDetailService.GetCustomerLimitMasterGroupsAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetLimitSharingGroupAsync()
    {
        var result = _client.LimitDetailService.GetLimitSharingGroupAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}