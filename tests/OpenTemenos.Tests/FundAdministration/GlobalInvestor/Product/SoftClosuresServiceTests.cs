using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SoftClosures;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class SoftClosureServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostSoftClosuresByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.SoftClosureService.PostSoftclosuresByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostSoftClosuresAsync()
    {
        var payload = new _0Payload();
        var result = _client.SoftClosureService.PostSoftclosuresAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutSoftClosuresAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SoftClosureService.PutSoftclosuresAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSoftClosuresAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.SoftClosureService.DeleteSoftclosuresAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetSoftClosuresByInternalIdAsync()
    {
        var result = _client.SoftClosureService
            .GetSoftclosuresByInternalIdAsync(InternalId)
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
            .PutSoftclosuresByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteSoftClosuresByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.SoftClosureService
            .DeleteSoftclosuresByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}