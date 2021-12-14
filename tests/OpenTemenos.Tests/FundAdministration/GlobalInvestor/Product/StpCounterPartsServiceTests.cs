using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.StpCounterParts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class StpCounterpartServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostStpCounterpartsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PostStpcounterpartsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostStpCounterpartsAsync()
    {
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PostStpcounterpartsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutStpCounterpartsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PutStpcounterpartsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteStpCounterpartsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StraightThroughProcessingCounterpartService
            .DeleteStpcounterpartsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetStpCounterpartsByInternalIdAsync()
    {
        var result = _client.StraightThroughProcessingCounterpartService
            .GetStpcounterpartsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutStpCounterpartsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PutStpcounterpartsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteStpCounterpartsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .DeleteStpcounterpartsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}