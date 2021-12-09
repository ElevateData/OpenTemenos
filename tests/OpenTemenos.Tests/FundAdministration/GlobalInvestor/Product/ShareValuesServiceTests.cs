using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ShareValues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class ShareValuesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostShareValuesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService.PostSharevaluesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostShareValuesAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService.PostSharevaluesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutShareValuesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareValueService.PutSharevaluesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteShareValuesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareValueService.DeleteSharevaluesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetShareValuesByInternalIdAsync()
    {
        var result = _client.TransferAgentFundShareValueService.GetSharevaluesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutShareValuesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService.PutSharevaluesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteShareValuesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService.DeleteSharevaluesByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}