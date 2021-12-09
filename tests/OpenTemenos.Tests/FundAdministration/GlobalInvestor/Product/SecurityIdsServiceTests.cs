using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.SecurityIds;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class SecurityIdServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityIdsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityIdService.PostSecurityidsByParentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityIdsAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityIdService.PostSecurityidsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityIdsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityIdService.PutSecurityidsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityIdsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityIdService.DeleteSecurityidsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecurityIdsByInternalIdAsync()
    {
        var result = _client.SecurityIdService
            .GetSecurityidsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityIdsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityIdService
            .PutSecurityidsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityIdsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityIdService
            .DeleteSecurityidsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}