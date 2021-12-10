using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.Securities;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class SecurityServiceTests : CredentialManagement
{
    private const string SecId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSecurityAsync()
    {
        var result = _client.SecurityService
            .GetSecurityAsync().Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityService.PostSecurityAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityService.PutSecurityAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityService.DeleteSecurityAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecurityBySecIdAsync()
    {
        var result = _client.SecurityService
            .GetSecurityBySecIdAsync(SecId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityBySecIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityService.PutSecurityBySecIdAsync(internalId, payload)
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
            .DeleteSecurityBySecIDAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}