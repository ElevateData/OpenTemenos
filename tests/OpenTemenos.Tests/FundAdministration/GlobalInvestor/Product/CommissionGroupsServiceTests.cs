using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.CommissionGroups;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class CommissionGroupsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostCommissionGroupsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.CommissionGroupService.PostcommissiongroupsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostCommissionGroupsAsync()
    {
        var payload = new _0Payload();
        var result = _client.CommissionGroupService.PostcommissiongroupsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutCommissionGroupsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CommissionGroupService.PutcommissiongroupsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteCommissionGroupsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CommissionGroupService.DeletecommissiongroupsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCommissionGroupsByInternalIdAsync()
    {
        var result = _client.CommissionGroupService.GetcommissiongroupsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutCommissionGroupsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.CommissionGroupService.PutcommissiongroupsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteCommissionGroupsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.CommissionGroupService.DeletecommissiongroupsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}