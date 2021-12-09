using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ShareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class ShareClassesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostShareClassesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService.PostShareclassesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostShareClassesAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService.PostShareclassesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutShareClassesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareClassService.PutShareclassesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteShareClassesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareClassService.DeleteShareclassesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetShareClassesByInternalIdAsync()
    {
        var result = _client.TransferAgentFundShareClassService.GetShareclassesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutShareClassesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService.PutShareclassesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteShareClassesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareClassService.DeleteShareclassesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}