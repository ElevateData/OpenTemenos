using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.StpCounterParts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class StpCounterpartsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostStpCounterpartsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PostStpcounterpartsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostStpCounterpartsAsync()
    {
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PostStpcounterpartsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutStpCounterpartsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StraightThroughProcessingCounterpartService
            .PutStpcounterpartsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteStpCounterpartsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StraightThroughProcessingCounterpartService
            .DeleteStpcounterpartsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetStpCounterpartsByInternalIdAsync()
    {
        var result = _client.StraightThroughProcessingCounterpartService
            .GetStpcounterpartsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
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
            .PutStpcounterpartsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteStpCounterpartsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.StraightThroughProcessingCounterpartService
            .DeleteStpcounterpartsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}