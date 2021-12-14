using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SecurityIds;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class SecurityIdServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityIdsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityIdService.PostSecurityidsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityIdsAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityIdService.PostSecurityidsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityIdsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityIdService.PutSecurityidsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityIdsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityIdService.DeleteSecurityidsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecurityIdsByInternalIdAsync()
    {
        var result = _client.SecurityIdService
            .GetSecurityidsByInternalIdAsync(InternalId)
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
            .PutSecurityidsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityIdsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityIdService
            .DeleteSecurityidsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}