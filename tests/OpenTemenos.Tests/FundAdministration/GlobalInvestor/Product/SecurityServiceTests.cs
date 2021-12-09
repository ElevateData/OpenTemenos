using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.Security;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class SecurityServiceTests : CredentialManagement
{
    private const string SecId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    public void GetSecurityAsync()
    {
        var result = _client.SecurityService
            .GetSecurityAsync(null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityService.PostSecurityAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityService.PutSecurityAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityService.DeleteSecurityAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecurityBySecIdAsync()
    {
        var result = _client.SecurityService
            .GetSecurityBySecIdAsync(null, null, null, null, null, null, null, null, null, null, SecId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityBySecIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityService.PutSecurityBySecIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityBySecIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityService
            .DeleteSecurityBySecIDAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}