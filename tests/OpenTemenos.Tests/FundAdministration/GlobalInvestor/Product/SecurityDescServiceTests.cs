using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.SecurityDesc;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class SecurityDescServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityDescByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityDescService.PostSecuritydescByParentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityDescAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityDescService.PostSecuritydescAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityDescAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityDescService.PutSecuritydescAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityDescAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityDescService.DeleteSecuritydescAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecurityDescByInternalIdAsync()
    {
        var result = _client.SecurityDescService
            .GetSecuritydescByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityDescByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityDescService
            .PutSecuritydescByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityDescByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityDescService
            .DeleteSecuritydescByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}