using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ShareValues;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class ShareValueServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostShareValuesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService
            .PostSharevaluesByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostShareValuesAsync()
    {
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService
            .PostSharevaluesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutShareValuesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareValueService
            .PutSharevaluesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteShareValuesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TransferAgentFundShareValueService
            .DeleteSharevaluesAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetShareValuesByInternalIdAsync()
    {
        var result = _client.TransferAgentFundShareValueService
            .GetSharevaluesByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutShareValuesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService
            .PutSharevaluesByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteShareValuesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TransferAgentFundShareValueService
            .DeleteSharevaluesByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}