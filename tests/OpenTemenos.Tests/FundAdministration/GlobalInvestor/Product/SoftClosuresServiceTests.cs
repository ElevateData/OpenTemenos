using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.SoftClosures;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class SoftClosuresServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSoftClosuresByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SoftClosureService.PostSoftclosuresByParentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSoftClosuresAsync()
    {
        var payload = new _0Payload();
        var result = _client.SoftClosureService.PostSoftclosuresAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSoftClosuresAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SoftClosureService.PutSoftclosuresAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSoftClosuresAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SoftClosureService.DeleteSoftclosuresAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSoftClosuresByInternalIdAsync()
    {
        var result = _client.SoftClosureService
            .GetSoftclosuresByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSoftClosuresByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SoftClosureService
            .PutSoftclosuresByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSoftClosuresByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SoftClosureService
            .DeleteSoftclosuresByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}