using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ShareClasses;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class ShareClassesServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostShareClassesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService
            .PostShareclassesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostShareClassesAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService
            .PostShareclassesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutShareClassesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareClassService
            .PutShareclassesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteShareClassesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareClassService
            .DeleteShareclassesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetShareClassesByInternalIdAsync()
    {
        var result = _client.TransferAgentFundShareClassService
            .GetShareclassesByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutShareClassesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService
            .PutShareclassesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteShareClassesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService
            .DeleteShareclassesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}