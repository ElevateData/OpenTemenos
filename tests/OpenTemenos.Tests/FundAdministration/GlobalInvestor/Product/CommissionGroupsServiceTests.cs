using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.CommissionGroups;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class CommissionGroupsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommissionGroupsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.CommissionGroupService
            .PostcommissiongroupsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostCommissionGroupsAsync()
    {
        var payload = new _0Payload();
        var result = _client.CommissionGroupService.PostcommissiongroupsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommissionGroupsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CommissionGroupService.PutcommissiongroupsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommissionGroupsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CommissionGroupService.DeletecommissiongroupsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCommissionGroupsByInternalIdAsync()
    {
        var result = _client.CommissionGroupService
            .GetcommissiongroupsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutCommissionGroupsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.CommissionGroupService
            .PutcommissiongroupsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCommissionGroupsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.CommissionGroupService
            .DeletecommissiongroupsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}