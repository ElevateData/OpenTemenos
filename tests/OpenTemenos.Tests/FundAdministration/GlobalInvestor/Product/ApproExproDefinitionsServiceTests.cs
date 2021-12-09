using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ApproExproDefinitions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class ApproExproDefinitionsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostApproExproDefinitionsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService.PostapproexprodefinitionsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostApproExproDefinitionsAsync()
    {
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService.PostapproexprodefinitionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutApproExproDefinitionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ApproOrExproDefinitionService.PutapproexprodefinitionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteApproExproDefinitionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ApproOrExproDefinitionService.DeleteapproexprodefinitionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetApproExproDefinitionsByInternalIdAsync()
    {
        var result = _client.ApproOrExproDefinitionService.GetapproexprodefinitionsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutApproExproDefinitionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService.PutapproexprodefinitionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteApproExproDefinitionsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ApproOrExproDefinitionService.DeleteapproexprodefinitionsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}