using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.EscalationChecks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class EscalationCheckServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostEscalationChecksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.EscalationCheckService
            .PostescalationchecksByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostEscalationChecksAsync()
    {
        var payload = new _0Payload();
        var result = _client.EscalationCheckService.PostescalationchecksAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutEscalationChecksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.EscalationCheckService.PutescalationchecksAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteEscalationChecksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.EscalationCheckService.DeleteescalationchecksAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEscalationChecksByInternalIdAsync()
    {
        var result = _client.EscalationCheckService
            .GetescalationchecksByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutEscalationChecksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.EscalationCheckService
            .PutescalationchecksByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteEscalationChecksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.EscalationCheckService
            .DeleteescalationchecksByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}