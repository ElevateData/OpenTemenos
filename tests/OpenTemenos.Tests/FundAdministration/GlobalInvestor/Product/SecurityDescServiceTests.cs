using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SecurityDescs;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class SecurityDescServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityDescByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityDescService.PostSecuritydescByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSecurityDescAsync()
    {
        var payload = new _0Payload();
        var result = _client.SecurityDescService.PostSecuritydescAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSecurityDescAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityDescService.PutSecuritydescAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityDescAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SecurityDescService.DeleteSecuritydescAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSecurityDescByInternalIdAsync()
    {
        var result = _client.SecurityDescService
            .GetSecuritydescByInternalIdAsync(InternalId)
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
            .PutSecuritydescByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSecurityDescByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SecurityDescService
            .DeleteSecuritydescByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}