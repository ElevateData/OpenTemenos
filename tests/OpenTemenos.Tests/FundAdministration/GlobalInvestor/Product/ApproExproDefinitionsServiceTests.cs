using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ApproExproDefinitions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class ApproExproDefinitionServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostApproExproDefinitionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService
            .PostapproexprodefinitionsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostApproExproDefinitionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService
            .PostapproexprodefinitionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutApproExproDefinitionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ApproOrExproDefinitionService
            .PutapproexprodefinitionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteApproExproDefinitionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ApproOrExproDefinitionService
            .DeleteapproexprodefinitionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetApproExproDefinitionsByInternalIdAsync()
    {
        var result = _client.ApproOrExproDefinitionService
            .GetapproexprodefinitionsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutApproExproDefinitionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService
            .PutapproexprodefinitionsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteApproExproDefinitionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService
            .DeleteapproexprodefinitionsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}