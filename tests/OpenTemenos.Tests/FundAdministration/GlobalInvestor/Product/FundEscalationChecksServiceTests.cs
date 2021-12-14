using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundEscalationChecks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class FundEscalationCheckServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundEscalationChecksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .PostfundescalationchecksByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundEscalationChecksAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .PostfundescalationchecksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundEscalationChecksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundEscalationCheckService
            .PutfundescalationchecksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundEscalationChecksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundEscalationCheckService
            .DeletefundescalationchecksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundEscalationChecksByInternalIdAsync()
    {
        var result = _client.FundEscalationCheckService
            .GetfundescalationchecksByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundEscalationChecksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .PutfundescalationchecksByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundEscalationChecksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .DeletefundescalationchecksByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}