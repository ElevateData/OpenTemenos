using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.AdlDealingDetails;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class AdlDealingDetailServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostAdlDealingDetailsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiDilutionLevyDealingService
            .PostAdlDealingDetailsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAdlDealingDetailsAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiDilutionLevyDealingService
            .PostAdlDealingDetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAdlDealingDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiDilutionLevyDealingService
            .PutAdlDealingDetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAdlDealingDetailsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiDilutionLevyDealingService
            .DeleteAdlDealingDetailsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAdlDealingDetailsByInternalIdAsync()
    {
        var result = _client.AntiDilutionLevyDealingService
            .GetAdlDealingDetailsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAdlDealingDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiDilutionLevyDealingService
            .PutAdlDealingDetailsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAdlDealingDetailsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiDilutionLevyDealingService
            .DeleteAdlDealingDetailsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}