using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundEscalationChecks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundEscalationChecksServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundEscalationChecksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .PostfundescalationchecksByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundEscalationChecksAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .PostfundescalationchecksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundEscalationChecksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundEscalationCheckService
            .PutfundescalationchecksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundEscalationChecksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundEscalationCheckService
            .DeletefundescalationchecksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundEscalationChecksByInternalIdAsync()
    {
        var result = _client.FundEscalationCheckService
            .GetfundescalationchecksByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
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
            .PutfundescalationchecksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundEscalationChecksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundEscalationCheckService
            .DeletefundescalationchecksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}